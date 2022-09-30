namespace GraphQL_Example
{
    using DAL;
    using Microsoft.EntityFrameworkCore;

    public static class ServicesConfiguration
    {
        public static void AddRequiredServices(this WebApplicationBuilder builder)
        {
            // Add services to the container.
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Register Repos
            //builder.Services.AddScoped<ISuperheroRepository, SuperheroRepository>();
            //builder.Services.AddScoped<ISuperpowerRepository, SuperpowerRepository>();
            //builder.Services.AddScoped<IMovieRepository, MovieRepository>();

            // Register GraphQL
            builder.Services.AddGraphQLServer()
                            .AddQueryType<Query>()
                            .AddProjections()
                            .AddSorting()
                            .AddFiltering();

            // Add Application Db Context options
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
        }
    }
}
