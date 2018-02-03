using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CST_356_Lab_2.Data;
using CST_356_Lab_2.Data.Entities;

namespace CST_356_Lab_2.Controllers
{
    public class UserController : Controller
    {
        // GET: Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (user.FirstName == null || user.LastName == null || user.EmailAddress == null)
                return RedirectToAction("Create");
            user.Id = InMemoryDatabase.NextId();
            InMemoryDatabase.Users.Add(user);

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var users = InMemoryDatabase.Users;

            return View(users);
        }
    }
}