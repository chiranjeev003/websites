using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookRentalService.Models;

namespace BookRentalService.Models
{
    public class BooksModels
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public GenreModels Genres { get; set; }

        public int GenresID { get; set; }

        public string Author { get; set; } = null;

        public DateTime? DateAddedInRecord { get; set; }

        public int NumberInStocks { get; set; }
    }
}