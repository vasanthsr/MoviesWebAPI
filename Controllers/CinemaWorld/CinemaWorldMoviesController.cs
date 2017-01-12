using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Movies.Models;

namespace Movies.Controllers
{
    public class CinemaWorldMoviesController : ApiController
    {
        static readonly ICinemaWorldMovieRepository repository = new CinemaWorldMovieRepository();

        //Get all movies
        public IEnumerable<Movie> GetAllMovies()
        {
            return repository.GetAll();
        }
        //Get Movie by id
        public Movie GetMovie(int id)
        {
            Movie item = repository.Get(id);
            if (item == null)
            {
               string message = "Movie doesn't exist";

                throw new HttpResponseException(
                    Request.CreateErrorResponse(HttpStatusCode.NotFound, message)); //handle exception
            }
            return item;
        }
        //Get movie by category
        public IEnumerable<Movie> GetMoviesByCategory(string category)
        {
            return repository.GetAll().Where(p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
        }

    }
}
