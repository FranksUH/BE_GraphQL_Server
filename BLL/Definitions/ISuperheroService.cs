﻿namespace BLL.Definitions
{
    using DAL.Entities;
    using System.Linq;

    public interface ISuperheroService
    {
        IQueryable<Superhero> GetAll();
    }
}
