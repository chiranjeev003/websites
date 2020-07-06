using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class MovieViewModel
    {
        [Required]
        public IEnumerable<Genres> Genre { get; set; }

        public int? ID { get; set; }

        [Required]
        public int? GenreId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; } = null;

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number left in stock")]
        public byte? NumberInStock { get; set; }

        public MovieViewModel(Movies movies)
        {
            ID = movies.ID;
            Name = movies.Name;
            ReleaseDate = movies.ReleaseDate;
            NumberInStock = movies.NumberInStock;
            GenreId = movies.GenreId;
        }

        public MovieViewModel()
        {
            ID = 0;
        }

        public string Title
        {
            get
            {
                return ID != 0 ? "Edit Movie" : "New Movie";
            }
        }
    }
}