using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            // create an instance of the move module
            Movie movie = new Movie()
            {
                Name = "Shrek"
            };

            //Render the view model
            return View(movie);
        }
    }
}