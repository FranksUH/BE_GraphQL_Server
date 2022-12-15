namespace GraphQL_Example
{
    using BLL.Definitions;
    using BLL.GraphQlObjectTypes;
    using BLL.Movies;
    using BLL.Superheros;
    using DAL;
    using DAL.Definitions;
    using DAL.Entities;
    using DAL.Implementations;
    using Microsoft.AspNetCore.OData;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.OData.Edm;
    using Microsoft.OData.ModelBuilder;

    public static class ServicesConfiguration
    {
        public static void AddRequiredServices(this WebApplicationBuilder builder)
        {
            //Configuration to OData
            builder.Services.AddControllers()
                            .AddOData(opt => opt
                            .AddRouteComponents("v1", GetEdmModel())
                            .EnableQueryFeatures());

            // Add services to the container.
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Register Repos
            builder.Services.AddScoped<IRepository<Superhero>, Repository<Superhero>>();
            builder.Services.AddScoped<IRepository<Superpower>, Repository<Superpower>>();
            builder.Services.AddScoped<IRepository<Movie>, Repository<Movie>>();

            //Register Services
            builder.Services.AddScoped<ISuperheroService, SuperheroService>();

            // Register GraphQL
            builder.Services.AddGraphQLServer()

                            .AddSubscriptionType<Subsciption>()
                            .AddInMemorySubscriptions()

                            .AddMutationType<Mutation>()
                            .AddMutationConventions(applyToAllMutations: true)

                            .AddQueryType<Query>()
                            .AddProjections()
                            .AddSorting()
                            .AddFiltering()

                            .AddTypeExtension<MovieQuery>();

            // Add Application Db Context options
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Superhero>("Superheros");

            builder.Namespace = "SuperheroService";
            builder.EntityType<Superhero>().Collection
                   .Function("GetTallest")
                   .Returns<double?>();

            return builder.GetEdmModel();
        }
    }
}
