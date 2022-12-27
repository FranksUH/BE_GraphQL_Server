namespace BLL.GraphQlObjectTypes
{
    using DAL.Entities;
    using HotChocolate;
    using HotChocolate.Types;

    public class Subsciption
    {
        [Subscribe]
        public Movie MovieAdded([EventMessage] Movie movie)
        {
            return movie;
        }
    }
}
