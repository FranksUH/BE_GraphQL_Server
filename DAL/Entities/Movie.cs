﻿namespace DAL.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Movie
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The movie title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The movie description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The movie instructor is required")]
        public string Instructor { get; set; }

        public DateTime? ReleaseDate { get; set; }

        [ForeignKey("SuperheroId")]
        public Guid? SuperheroId { get; set; }
        public Superhero? Superhero { get; set; }
    }
}
