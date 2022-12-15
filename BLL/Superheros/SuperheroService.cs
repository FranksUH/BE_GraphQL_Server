namespace BLL.Superheros
{
    using BLL.Definitions;
    using DAL.Definitions;
    using DAL.Entities;
    using System.Linq;

    public class SuperheroService: ISuperheroService
    {
        private IRepository<Superhero> superheroRepo;

        public SuperheroService(IRepository<Superhero> repository)
        {
            this.superheroRepo = repository;
        }

        public IQueryable<Superhero> GetAll()
        {
            return this.superheroRepo.GetAll();
        }

        public double? GetTallest()
        {
            return this.superheroRepo.GetAll().Where(x => x.Height.HasValue).OrderByDescending(x => x.Height).FirstOrDefault()?.Height;
        }

        public Superhero Upsert(Superhero superhero)
        {
            if(superhero.Id != Guid.Empty)
            {
                Superhero existingEntity = this.superheroRepo.Find(superhero.Id);

                if(existingEntity != null)
                {
                    return this.superheroRepo.Modify(existingEntity);
                }
            }

            return this.superheroRepo.Add(superhero);
        }
    }
}
