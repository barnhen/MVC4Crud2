using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC4Crud2.Models;

namespace MVC4Crud2.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext db = new ContactContext();

        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View(db.Contacts.ToList());
        }

        //
        // GET: /Contact/Details/5

        public ActionResult Details(int id = 0)
        {
            ContactModels contactmodels = db.Contacts.Find(id);
            if (contactmodels == null)
            {
                return HttpNotFound();
            }
            return View(contactmodels);
        }

        //
        // GET: /Contact/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Contact/Create

        [HttpPost]
        public ActionResult Create(ContactModels contactmodels)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contactmodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactmodels);
        }

        //
        // GET: /Contact/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ContactModels contactmodels = db.Contacts.Find(id);
            if (contactmodels == null)
            {
                return HttpNotFound();
            }
            return View(contactmodels);
        }

        //
        // POST: /Contact/Edit/5

        [HttpPost]
        public ActionResult Edit(ContactModels contactmodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactmodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactmodels);
        }

        //
        // GET: /Contact/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ContactModels contactmodels = db.Contacts.Find(id);
            if (contactmodels == null)
            {
                return HttpNotFound();
            }
            return View(contactmodels);
        }

        //
        // POST: /Contact/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactModels contactmodels = db.Contacts.Find(id);
            db.Contacts.Remove(contactmodels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}