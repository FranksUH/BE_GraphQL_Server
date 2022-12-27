namespace BLL.GraphQlObjectTypes
{
    using DAL.Definitions;
    using DAL.Entities;
    using HotChocolate;
    using HotChocolate.Subscriptions;

    /// <summary>
    /// This Class exposes what we want to be able to modify from GraphQL
    /// </summary>
    public class Mutation
    {
        public Movie AddMovie([Service] IRepository<Movie> repository,
                              [Service] ITopicEventSender sender,
                              string title, string description, string instructor, Guid? superheroId)
        {
            Movie newMovie = new Movie
            {
                Id = Guid.NewGuid(),
                Description = description,
                Instructor = instructor,
                Title = title,
                ReleaseDate = DateTime.UtcNow,
                SuperheroId = superheroId
            };

            Movie result = repository.Add(newMovie);
            sender.SendAsync(nameof(Subsciption.MovieAdded), result);

            return result;
        }
    }
}
