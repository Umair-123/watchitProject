using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchIt.Models;
namespace WatchIt.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        public ActionResult MoviesCategories()
        {
            var repository = new MovieRepository();
            return View(repository.GetMovies().OrderBy(m => m.YearReleased));
        }

    }
}
