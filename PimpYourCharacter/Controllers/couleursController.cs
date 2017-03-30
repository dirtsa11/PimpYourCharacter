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
    public class CouleursController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Couleurs
        public ActionResult Index()
        {
            return View(db.couleur.ToList());
        }

        // GET: Couleurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            couleur couleur = db.couleur.Find(id);
            if (couleur == null)
            {
                return HttpNotFound();
            }
            return View(couleur);
        }

        // GET: Couleurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Couleurs/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_couleur,label")] couleur couleur)
        {
            if (ModelState.IsValid)
            {
                db.couleur.Add(couleur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(couleur);
        }

        // GET: Couleurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            couleur couleur = db.couleur.Find(id);
            if (couleur == null)
            {
                return HttpNotFound();
            }
            return View(couleur);
        }

        // POST: Couleurs/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_couleur,label")] couleur couleur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(couleur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(couleur);
        }

        // GET: Couleurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            couleur couleur = db.couleur.Find(id);
            if (couleur == null)
            {
                return HttpNotFound();
            }
            return View(couleur);
        }

        // POST: Couleurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            couleur couleur = db.couleur.Find(id);
            db.couleur.Remove(couleur);
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
