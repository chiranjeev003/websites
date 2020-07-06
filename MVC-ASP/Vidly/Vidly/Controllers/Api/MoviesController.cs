using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Net;
using System.Data.Entity;
using Vidly.Models;
using AutoMapper;
using Vidly.Dtos;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //get api/movies
        public IHttpActionResult GetMovies()
        {
            var movies = _context.Movies
                .Include(c => c.Genre)
                .ToList()
                .Select(Mapper.Map<Movies, MoviesDto>);
            return Ok(movies);

        //    var sql = @"select * from (select m.Movie_Name ,m.ID, g.Name from Movies as m
        //                inner join Genres as g
        //                on g.Id = m.GenreId) as tableMovies";
        //    IEnumerable<MoviesDto> movies = _context.Database.SqlQuery<MoviesDto>(sql);
        //    return Ok(movies.ToList());
        }

            //get api/movies/1
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.ID == id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movies, MoviesDto>(movie));
        }

        //post api/movie
        [HttpPost]
        public IHttpActionResult CreateMovie(MoviesDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MoviesDto, Movies>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.ID = movie.ID;

            return Created(new Uri(Request.RequestUri + "/" + movie.ID), movieDto);
        }

        //put api/Movie/1
        [HttpPut]
        public void UpdateMovie(int id, Movies moviesDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var MovieInDb = _context.Movies.SingleOrDefault(c => c.ID == id);

            if (MovieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(moviesDto, MovieInDb);

            _context.SaveChanges();
        }

        //Delete api/Movie/1
        [HttpDelete]
        public void DeleteMovie(int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var MovieInDb = _context.Movies.SingleOrDefault(c => c.ID == id);

            if (MovieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(MovieInDb);
            _context.SaveChanges();
        }
    }
}
