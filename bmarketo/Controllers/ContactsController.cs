﻿using bmarketo.Contexts;
using bmarketo.Models.Entities;
using bmarketo.Services;
using bmarketo.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace bmarketo.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ContactFormService _contactFormService;
        public ContactsController(ContactFormService contactFormService)
        {
            _contactFormService = contactFormService;
        }


        public IActionResult Index()
        {
            ViewData["Title"] = "Contact Us";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterContactForm(ContactFormViewModel contactFormViewModel)
        {
            if (ModelState.IsValid)
            {
                    if (await _contactFormService.RegisterContactFormAsync(contactFormViewModel))
                    {
                        return RedirectToAction("index", "home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Something went wrong when creating the form. Try Again.");
                    }
            }

            ViewData["Title"] = "Register";
            return View(contactFormViewModel);






        }


    }
}
