﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniPhoneBook.Controllers
{
    public class personController : Controller
    {
        // GET: person
        public ActionResult Index()
        {
            return View();
        }

        // GET: person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: person/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
