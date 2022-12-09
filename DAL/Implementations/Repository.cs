namespace DAL.Implementations
{
    using DAL.Definitions;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext appDbContext;
        private DbSet<TEntity> Set { get; }

        public Repository(ApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            Set = appDbContext.Set<TEntity>();
        }

        /// <inheritdoc/>
        public TEntity Add(TEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            TEntity result = Set.Add(item).Entity;
            this.appDbContext.SaveChanges();

            return result;
        }

        /// <inheritdoc/>
        public TEntity? Find(params object[] entityKeyValues)
        {
            TEntity? entity = null;

            if (entityKeyValues != null && entityKeyValues.Length > 0)
            {
                entity = Set.Find(entityKeyValues);
            }

            return entity;
        }

        /// <inheritdoc/>
        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null, bool noTracking = false, params Expression<Func<TEntity, object>>[] joinedEntities)
        {
            IQueryable<TEntity> query = Set;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (joinedEntities != null)
            {
                query = joinedEntities.Aggregate(query, (current, joinedEntity) => current.Include(joinedEntity));
            }

            if (noTracking)
            {
                query = query.AsNoTracking();
            }

            return query;
        }

        /// <inheritdoc/>
        public TEntity Modify(TEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            Set.Attach(item);
            this.appDbContext.Entry(item).State = EntityState.Modified;

            return item;
        }

        /// <inheritdoc/>
        public TEntity Remove(TEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            return Set.Remove(item).Entity;
        }

        //Explicit Load support
        public virtual void Include(TEntity entity, params Expression<Func<TEntity, object>>[] joinedEntities)
        {
            EntityEntry<TEntity> entry = appDbContext.Entry(entity);

            foreach (Expression<Func<TEntity, object>> join in joinedEntities)
            {
                Func<TEntity, object> func = join.Compile();
                if (func.Invoke(entity) == null)
                {
                    entry.Reference(join).Load();
                }
            }
        }

        public virtual void IncludeCollection(TEntity entity, params Expression<Func<TEntity, IEnumerable<object>>>[] joinedEntities)
        {
            EntityEntry<TEntity> entry = appDbContext.Entry(entity);

            foreach (Expression<Func<TEntity, IEnumerable<object>>> join in joinedEntities)
            {
                Func<TEntity, object> func = join.Compile();
                if (func.Invoke(entity) == null)
                {
                    entry.Collection(join).Load();
                }
            }
        }
    }
}
