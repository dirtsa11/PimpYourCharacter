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
    public class nezController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: nez
        public ActionResult Index()
        {
            return View(db.nez.ToList());
        }

        // GET: nez/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nez nez = db.nez.Find(id);
            if (nez == null)
            {
                return HttpNotFound();
            }
            return View(nez);
        }

        // GET: nez/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: nez/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_nez,hauteur,largeur,profondeur,forme")] nez nez)
        {
            if (ModelState.IsValid)
            {
                db.nez.Add(nez);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nez);
        }

        // GET: nez/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nez nez = db.nez.Find(id);
            if (nez == null)
            {
                return HttpNotFound();
            }
            return View(nez);
        }

        // POST: nez/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_nez,hauteur,largeur,profondeur,forme")] nez nez)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nez).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nez);
        }

        // GET: nez/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nez nez = db.nez.Find(id);
            if (nez == null)
            {
                return HttpNotFound();
            }
            return View(nez);
        }

        // POST: nez/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            nez nez = db.nez.Find(id);
            db.nez.Remove(nez);
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
