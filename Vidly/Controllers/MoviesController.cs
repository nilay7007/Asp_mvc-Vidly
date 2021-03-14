using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);

        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }

            };
        }
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customer = new List<Customer> { new Customer{ Name = "nilay" }, new Customer { Name = "Sachan" } };

            var cusmovie = new RandomCustomerMovie { Customer = customer, Movie = movie };

            return View(cusmovie);
        }
    }
}