using System;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using CST356_Lab_5.Models.View;
using CST356_Lab_5.Services;

namespace CST356_Lab_5.Controllers
{
    [Authorize]
    public class PetController : Controller
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        public ActionResult List()
        {
            var userId = User.Identity.GetUserId();

            var petViewModels = _petService.GetPetsForUser(userId);

            return View(petViewModels);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PetViewModel petViewModel)
        {

            if (!ModelState.IsValid) return View();

            try
            {
                var userId = User.Identity.GetUserId();
                _petService.SavePet(userId, petViewModel);
            }
            catch (Exception)
            {
                throw;
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var pet = _petService.GetPet(id);

            return View(pet);
        }

        [HttpPost]
        public ActionResult Edit(PetViewModel petViewModel)
        {
            if (ModelState.IsValid)
            {
                _petService.UpdatePet(petViewModel);

                return RedirectToAction("List");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var pet = _petService.GetPet(id);

            return View(pet);
        }

        public ActionResult Delete(int id)
        {
            _petService.DeletePet(id);

            return RedirectToAction("List");
        }
    }
}