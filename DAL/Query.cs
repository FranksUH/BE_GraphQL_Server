namespace DAL
{
    using DAL.Entities;
    using System.Linq;

    /// <summary>
    /// This Class exposes what we want to be accessible from GraphQL
    /// </summary>
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) => context.Superheroes;
    }
}