using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchIt.Models;
namespace WatchIt.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/

        public ActionResult UploadMovie()
        {
            return View();
        }
        public ActionResult SaveMovie(Movie movie)
        {
            return RedirectToAction("UploadMovie");
        }

    }
}
