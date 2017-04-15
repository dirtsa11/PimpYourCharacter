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
    public class BouclierController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Bouclier
        public ActionResult Index()
        {
            return View(db.bouclier.ToList());
        }

        // GET: Bouclier/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bouclier bouclier = db.bouclier.Find(id);
            if (bouclier == null)
            {
                return HttpNotFound();
            }
            return View(bouclier);
        }

        // GET: Bouclier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bouclier/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_bouclier,label,poids")] bouclier bouclier)
        {
            if (ModelState.IsValid)
            {
                db.bouclier.Add(bouclier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bouclier);
        }

        // GET: Bouclier/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bouclier bouclier = db.bouclier.Find(id);
            if (bouclier == null)
            {
                return HttpNotFound();
            }
            return View(bouclier);
        }

        // POST: Bouclier/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_bouclier,label,poids")] bouclier bouclier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bouclier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bouclier);
        }

        // GET: Bouclier/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bouclier bouclier = db.bouclier.Find(id);
            if (bouclier == null)
            {
                return HttpNotFound();
            }
            return View(bouclier);
        }

        // POST: Bouclier/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bouclier bouclier = db.bouclier.Find(id);
            db.bouclier.Remove(bouclier);
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
