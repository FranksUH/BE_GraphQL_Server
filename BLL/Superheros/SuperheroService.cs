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
    }
}
