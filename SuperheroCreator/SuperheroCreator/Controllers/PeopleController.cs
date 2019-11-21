using SuperheroCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperheroCreator.Controllers
{
    public class PeopleController : Controller
    {
        ApplicationDbContext db;

        public PeopleController()
        {
            db = new ApplicationDbContext(); // Instantiating database
        }
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        // GET: People/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: People/Create
        public ActionResult Create()
        {
            Person person = new Person();
            return View(person);
        }

        // POST: People/Create
        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                // TODO: Add insert logic here
                db.People.Add(person); // Adds all columns under the People table
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: People/Edit/5
        public ActionResult Edit(int id)
        {
            return View(id);
        }

        // POST: People/Edit/5
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

        // GET: People/Delete/5
        public ActionResult Delete(int id)
        {
            Person person = db.People.Where(p => p.Id == id).FirstOrDefault(); // Matching person's ID to parameter id
            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Person person)
        {
            try
            {
                // TODO: Add delete logic here
                person = db.People.Where(p => p.Id == id).FirstOrDefault();
                db.People.Remove(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
