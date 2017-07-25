﻿using PersonWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonApplicationDll.Entities;
using PersonApplicationDll;
using PersonApplicationDll.Managers;

namespace PersonWebApp.Controllers
{
    public class PersonController : Controller
    {
        private IManager<Person> _pm = new DllFacade().GetPersonManager();
        private IManager<PersonStatus> _psm = new DllFacade().GetPersonStatusManager();
        
        // GET: Person
        public ActionResult Index()
        {
            return View(_pm.Read());
        }


        public ActionResult Create()
        {
            return View(_psm.Read());
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            _pm.Create(person);
            return RedirectToAction("Index");
        }
        


        public ActionResult Edit(int id)
        {
            var personToEdit = _pm.Read(id);
            if (personToEdit == null) return RedirectToAction("Index");
            var viewModel = new EditPersonViewModel
            {
                Person = personToEdit,
                Statuses = _psm.Read()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(Person p)
        {
            _pm.Update(p);
            return RedirectToAction("Index");
        }
        
        public ActionResult Delete(int id)
        {
            var personToDelete = _pm.Read(id);
            if (personToDelete == null) return RedirectToAction("Index");

            return View(personToDelete);
        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                _pm.Delete(id.Value);
            }
            return RedirectToAction("Index");
        }
    }
}