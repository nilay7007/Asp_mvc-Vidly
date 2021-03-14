using IdentitySample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);

        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);

        
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