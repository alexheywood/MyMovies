using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
#nullable enable
        public string? Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string? Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

#nullable enable

        [Display(Name = "Cover Image:")]
        public string? ImageUrl { get; set; }

        public int Rating { get; set; }
    }
}