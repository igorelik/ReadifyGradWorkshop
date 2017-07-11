using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkshopMVC.Business;
using WorkshopMVC.Models;

namespace WorkshopMVC.Controllers
{
    public class HomeController : Controller
    {
        private IModelService _modelService;

        public HomeController(IModelService modelService)
        {
            _modelService = modelService;
        }

        //public HomeController()
        //{
        //    _modelService = new ModelService();
        //    Model = _modelService.GetEmptyModel();
        //}

        public SimpleModel Model { get; set; } // = new SimpleModel { Name = "My name", Nickname = "My nickname" };
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "My About page";
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            Model = _modelService.GetEmptyModel();
            ViewBag.Message = "Your contact page.";
            ViewBag.Model = Model;

            return View(Model);
        }
    }
}