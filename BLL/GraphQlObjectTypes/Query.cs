namespace BLL.GraphQlObjectTypes
{
    using DAL.Definitions;
    using DAL.Entities;
    using HotChocolate;
    using HotChocolate.Data;
    using System.Linq;

    /// <summary>
    /// This Class exposes what we want to be accessible from GraphQL
    /// </summary>
    public class Query
    {        
        public IQueryable<Movie> GetMovies([Service] IRepository<Movie> repository)
        {
            return repository.GetAll();
        }


        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> GetSuperheroes([Service] IRepository<Superhero> repository)
        {
            return repository.GetAll();
        }
    }
}