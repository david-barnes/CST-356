using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CST356_Lab_5.Models.View;
using CST356_Lab_5.Services;

namespace CST356_Lab_5.Controllers
{
    public class PetController : Controller
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        public ActionResult List(int userId)
        {
            //_log.Debug("Getting list of pets for user: " + userId);

            ViewBag.UserId = userId;

            var petViewModels = _petService.GetPetsForUser(userId);

            return View(petViewModels);
        }

        [HttpGet]
        public ActionResult Create(int userId)
        {
            ViewBag.UserId = userId;

            return View();
        }

        [HttpPost]
        public ActionResult Create(PetViewModel petViewModel)
        {
            //_log.Info("Creating pet");

            if (ModelState.IsValid)
            {
                try
                {
                    _petService.SavePet(petViewModel);
                }
                catch (Exception)
                {
                    //_log.Error("Failed to save pet.", ex);
                    throw;
                }

                return RedirectToAction("List", new { UserId = petViewModel.UserId });
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            var petViewModel = _petService.GetPet(id);
            
            return View(petViewModel);
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

        public ActionResult Delete(int id)
        {
            var pet = _petService.GetPet(id);

            _petService.DeletePet(id);

            return RedirectToAction("List", new { UserId = pet.UserId });
        }
    }
}