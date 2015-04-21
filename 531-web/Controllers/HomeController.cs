using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _531_web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult WorkoutGuide()
        {
            ViewBag.Message = "Your workout summary page.";

                return View();
        }
        public ActionResult CustomWorkoutPlans()
        {
            ViewBag.Message = "A place to make your own workouts!";

            return View();
        }
    }
}