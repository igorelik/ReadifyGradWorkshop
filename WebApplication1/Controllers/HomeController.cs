using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public SimpleModel Model { get; set; } = new SimpleModel() { Name = "NameTest", Nickname = "Hahahaha" };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "This is a title.";
            ViewBag.Message = "Your application description page.";

            ViewBag.Model = Model;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            ViewBag.Model = Model;
            return View();
        }
    }
}