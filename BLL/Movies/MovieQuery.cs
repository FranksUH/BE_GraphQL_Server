namespace BLL.Movies
{
    using BLL.GraphQlObjectTypes;
    using DAL.Definitions;
    using DAL.Entities;
    using HotChocolate;
    using HotChocolate.Types;
    using System.Linq;

    //GraphQL example to show Query extensors

    [ExtendObjectType(typeof(Query))]
    public class MovieQuery
    {
        [UsePaging(IncludeTotalCount = true, MaxPageSize = 2)]
        public IQueryable<Movie> GetMoviesPaginated([Service] IRepository<Movie> repository,[Parent] Query movie)
        {
            return repository.GetAll();
        }

        [UseOffsetPaging(IncludeTotalCount = true, MaxPageSize = 2)]
        public IQueryable<Movie> GetMoviesOffsetPaginated([Service] IRepository<Movie> repository, [Parent] Query movie)
        {
            return repository.GetAll();
        }
    }
}
