using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;
using System.Data.Entity.Validation;


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            var genre = _context.Genres.ToList();
            var viewModel = new MovieViewModel
            {
                Genre = genre
            };
            return View(viewModel);
        }

        // GET: Movies
        //public ActionResult Details()
        //{


        //    //var movie = new Movies()
        //    //{
        //    //    Name = "Shrek"
        //    //};

        //    //var viewModel = new DetailMovieViewModel {
        //    //    Movie = movie,
        //    //    //Customers = customers
        //    //};

        //    //return View(viewModel);
        //}

        public static List<Movies> movies()
        {
            List<Movies> customers = new List<Movies>();
            customers.Add(new Movies { Name = "Singham" });
            customers.Add(new Movies { Name = "Wanted" });

            return customers;

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Save(Movies movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieViewModel(movie)
                {
                    Genre = _context.Genres.ToList()
                };

                return View("New", viewModel);
            }

            if (movie.ID == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.ID == movie.ID);
                movieInDb.Name = movie.Name;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.DateAdded = movie.DateAdded;
                movieInDb.DateAdded = movie.DateAdded;
            }
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                throw e;
            }
            return RedirectToAction("Index", "Movies");
        }

        //Edit: Movies
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var movies = _context.Movies.SingleOrDefault(m => m.ID == id);

            if (movies == null)
                return HttpNotFound();

            var viewModel = new MovieViewModel(movies)
            {
                Genre = _context.Genres.ToList()
            };

            return View("New", viewModel);
        }

        [Authorize(Roles =RoleName.CanManageMovies)]
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.ID == id);

            return View(movie);
        }

        //View movie List
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("Index");

            return View("ReadOnlyList");
        }

        //public ActionResult Customers()
        //{

        //}

        //view movie by release date
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}