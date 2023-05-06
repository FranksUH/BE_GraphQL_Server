namespace GraphQL_Example.Controllers
{
    using BLL.Definitions;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.OData.Query;

    [Route("api/[controller]")]
    [ApiController]
    public class SuperheroODataController : ControllerBase
    {
        private readonly ISuperheroService superheroService;
        public SuperheroODataController(ISuperheroService superheroService)
        {
            this.superheroService = superheroService;
        }

        [HttpGet("/")]
        [EnableQuery]
        public ActionResult GetAllSuperheros()
        {
            return Ok(this.superheroService.GetAll());
        }
    }
}
