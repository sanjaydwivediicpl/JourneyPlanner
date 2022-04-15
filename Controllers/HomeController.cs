using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JourneyPlanner.Models;
using JourneyPlanner.Services;
using Newtonsoft.Json;
namespace JourneyPlanner.Controllers
{
    public class HomeController : Controller
    {
        // Services this controller utilises are defined here
        private IJourneyService _journeyService;
        // Constructors
        public HomeController()
            : this(new JourneyService()) { }

        public HomeController(IJourneyService JourneyService)
        {
            this._journeyService = JourneyService;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(JourneyModel journeyModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = _journeyService.GetPlaces().Where(j => j.FromStation == journeyModel.From && j.ToStation == journeyModel.To).ToList();
                if (result.Count > 0)
                {
                    return View(result);
                }
                else
                {
                    ViewBag.Message = "Record does not exists.";
                    return View();
                }

            }
            else
            {
                return View();
            }
        }
    }
}