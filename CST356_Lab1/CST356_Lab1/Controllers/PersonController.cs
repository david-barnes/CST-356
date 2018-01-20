using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CST356_Lab1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            ViewBag.Name = "My name is David.";
            ViewBag.Message = "Have a pleasent day.";
            return View();
        }
    }
}