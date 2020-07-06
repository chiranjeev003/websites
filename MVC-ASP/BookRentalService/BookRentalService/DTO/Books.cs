using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookRentalService.DTO
{
    public class Books
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Models.GenreModels Genres { get; set; }

        public int GenresID { get; set; }

        public string Author { get; set; } = null;

        public DateTime? DateAddedInRecord { get; set; }

        public int NumberInStocks { get; set; }
    }
}