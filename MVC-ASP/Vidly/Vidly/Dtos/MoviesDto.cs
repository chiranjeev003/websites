using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MoviesDto
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public GenreDto Genre { get; set; }

        public int GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; } = null;

        [Display(Name = "Date in which added")]
        public DateTime? DateAdded { get; set; } = null;

        [Display(Name = "Number left in stock")]
        public byte NumberInStock { get; set; }
    }
}