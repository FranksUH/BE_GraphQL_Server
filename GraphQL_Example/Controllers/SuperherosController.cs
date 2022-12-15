namespace GraphQL_Example.Controllers
{
    using BLL.Definitions;
    using DAL.Entities;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.OData.Formatter;
    using Microsoft.AspNetCore.OData.Query;
    using Microsoft.AspNetCore.OData.Routing.Controllers;
    using Microsoft.EntityFrameworkCore;

    public class SuperherosController : ODataController
    {
        private readonly ISuperheroService superheroService;
        public SuperherosController(ISuperheroService superheroService)
        {
            this.superheroService = superheroService;
        }

        [EnableQuery(PageSize = 25, AllowedQueryOptions = AllowedQueryOptions.All)]
        public IQueryable<Superhero> GetSuperheros()
        {
            return this.superheroService.GetAll();
        }

        [EnableQuery(PageSize = 25, AllowedQueryOptions = AllowedQueryOptions.All)]
        public Superhero Get([FromODataUri] Guid key)
        {
            return this.superheroService.GetAll().FirstOrDefault(x => x.Id == key);
        }

        [EnableQuery(PageSize = 15)]
        public ActionResult GetMovies([FromODataUri] Guid key)
        {
            return Ok(this.superheroService.GetAll().Include(x => x.Movies).FirstOrDefault(x => x.Id == key)?.Movies);
        }

        [EnableQuery]
        public ActionResult GetTallest()
        {
            return Ok(this.superheroService.GetTallest());
        }

        //[EnableQuery]
        //public Superhero Get(string name)
        //{
        //    return this.superheroService.GetAll().Where(x => x.Name == name).FirstOrDefault();
        //}

        [EnableQuery]
        public ActionResult Post([FromBody] Superhero superhero)
        {
            return Ok(this.superheroService.Upsert(superhero));
        }
    }
}
