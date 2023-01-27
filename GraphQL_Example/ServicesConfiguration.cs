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

    public static class ServicesConfiguration
    {
        public static void AddRequiredServices(this WebApplicationBuilder builder)
        {
            //Configuration to OData
            builder.Services.AddControllers()
                            .AddOData(opt => opt
                            .Select()
                            .Filter()
                            .OrderBy()
                            .Expand());

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
    }
}
