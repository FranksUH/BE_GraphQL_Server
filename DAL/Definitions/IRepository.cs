namespace DAL.Definitions
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Base interface for implement a "Repository Pattern".
    /// </summary>
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Add item into repository.
        /// </summary>
        /// <param name="item">Item to add to repository.</param>
        TEntity Add(TEntity item);

        /// <summary>
        /// Delete item.
        /// </summary>
        /// <param name="item">Item to delete.</param>
        TEntity Remove(TEntity item);

        /// <summary>
        /// Modify an entity into the repository. 
        /// </summary>
        /// <param name="item">Item with changes.</param>
        TEntity Modify(TEntity item);

        /// <summary>
        /// Get all elements of type <typeparamref name="TEntity" /> in repository.
        /// </summary>
        /// <param name="filter">Filters the elements in database BEFORE materialize the query.</param>
        /// <param name="noTracking">Indicates that the resulting objects are not tracked by EF.</param>
        /// <param name="joinedEntities">
        ///     Include these entities in the query result, otherwise these navigation fields will be
        ///     null.
        /// </param>
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null, bool noTracking = false,
            params Expression<Func<TEntity, object>>[] joinedEntities);

        /// <summary>
        /// Gets an element by it's entity key.
        /// </summary>
        /// <param name="entityKeyValues">Entity key values, the order the are same of order in mapping.</param>
        TEntity? Find(params object[] entityKeyValues);

        void IncludeCollection(TEntity entity, params Expression<Func<TEntity, IEnumerable<object>>>[] joinedEntities);

        void Include(TEntity entity, params Expression<Func<TEntity, object>>[] joinedEntities);
    }
}
