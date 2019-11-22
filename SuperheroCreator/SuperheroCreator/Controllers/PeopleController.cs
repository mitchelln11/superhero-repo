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
            //IQueryable<Person> heros = db.People;
            //var heros = db.People.ToList();
            //var heros = db.People.Where(p => p.Id == id).FirstOrDefault();
            return View("Index", db.People); // Trying to display the entire Person table
        }

        // GET: People/Details/5
        public ActionResult Details(int id, Person person)
        {
            person = db.People.Where(p => p.Id == id).FirstOrDefault();
            return View(person);
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
            Person person = db.People.Where(p => p.Id == id).FirstOrDefault(); // Matching person's ID to parameter id
            return View(person);
        }

        // POST: People/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Person person)
        {
            try
            {
                // Run through Table
                Person personToEdit = db.People.Where(p => p.Id == id).FirstOrDefault();
                // 
                personToEdit.superHeroName = person.superHeroName;
                personToEdit.firstName = person.firstName;
                personToEdit.lastName = person.lastName;
                personToEdit.primaryAbility = person.primaryAbility;
                personToEdit.secondaryAbility = person.secondaryAbility;
                personToEdit.catchPhrase = person.catchPhrase;
                personToEdit.heroImage = person.heroImage;
                db.SaveChanges();
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

        //// Image in database
        //public ActionResult AddImage()
        //{
        //    ImgFormat img = new ImgFormat();
        //    return View(img);
        //}

        //public ActionResult AddImage(ImgFormat imgFormat, HttpPostedFileBase heroImage)
        //{
        //    if (heroImage != null)
        //    {
        //        imgFormat.BrandImage = new byte[imgFormat.ContentLength];
        //        heroImage.InputStream.Read(imgFormat.BrandImage, 0, heroImage.ContentLength);
        //    }
        //}

        // POST: People/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Person person)
        {
            try
            {
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
