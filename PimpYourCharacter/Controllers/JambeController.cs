using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PimpYourCharacter.Models;

namespace PimpYourCharacter.Controllers
{
    public class JambeController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Jambe
        public ActionResult Index()
        {
            return View(db.jambe.ToList());
        }

        // GET: Jambe/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jambe jambe = db.jambe.Find(id);
            if (jambe == null)
            {
                return HttpNotFound();
            }
            return View(jambe);
        }

        // GET: Jambe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jambe/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_jambe,hauteur,forme")] jambe jambe)
        {
            if (ModelState.IsValid)
            {
                db.jambe.Add(jambe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jambe);
        }

        // GET: Jambe/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jambe jambe = db.jambe.Find(id);
            if (jambe == null)
            {
                return HttpNotFound();
            }
            return View(jambe);
        }

        // POST: Jambe/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_jambe,hauteur,forme")] jambe jambe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jambe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jambe);
        }

        // GET: Jambe/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jambe jambe = db.jambe.Find(id);
            if (jambe == null)
            {
                return HttpNotFound();
            }
            return View(jambe);
        }

        // POST: Jambe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            jambe jambe = db.jambe.Find(id);
            db.jambe.Remove(jambe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
