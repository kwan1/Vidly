using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //attribute route
      
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Fast and Furious 4" };

            var customers = new List<Customer> {
                new Customer {Name= "Customer 1"},
                new Customer { Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };
            return View(viewModel);


        }
  
     
    }
}