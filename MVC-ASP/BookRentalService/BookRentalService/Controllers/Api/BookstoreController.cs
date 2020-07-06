using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BookRentalService.Models;
using System.Data.Entity;

namespace BookRentalService.Controllers
{
    public class BookstoreController : ApiController
    {

        private ApplicationDbContext _context;

        public BookstoreController()
        {
            _context = new ApplicationDbContext();
        }

        //get api/customers
        public IList<BooksModels> GetBooks()
        {
            return _context.Books.Include(c=>c.Genres).ToList();
        }

    }
}
