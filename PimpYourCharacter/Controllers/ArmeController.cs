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
    public class ArmeController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Arme
        public ActionResult Index()
        {
            var arme = db.arme.Include(a => a.categorie_arme);
            return View(arme.ToList());
        }

        // GET: Arme/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arme arme = db.arme.Find(id);
            if (arme == null)
            {
                return HttpNotFound();
            }
            return View(arme);
        }

        // GET: Arme/Create
        public ActionResult Create()
        {
            ViewBag.id_categorie_arme = new SelectList(db.categorie_arme, "id_categorie_arme", "categorie_arme1");
            return View();
        }

        // POST: Arme/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_arme,label,poids,id_categorie_arme")] arme arme)
        {
            if (ModelState.IsValid)
            {
                db.arme.Add(arme);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_categorie_arme = new SelectList(db.categorie_arme, "id_categorie_arme", "categorie_arme1", arme.id_categorie_arme);
            return View(arme);
        }

        // GET: Arme/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arme arme = db.arme.Find(id);
            if (arme == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_categorie_arme = new SelectList(db.categorie_arme, "id_categorie_arme", "categorie_arme1", arme.id_categorie_arme);
            return View(arme);
        }

        // POST: Arme/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_arme,label,poids,id_categorie_arme")] arme arme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arme).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_categorie_arme = new SelectList(db.categorie_arme, "id_categorie_arme", "categorie_arme1", arme.id_categorie_arme);
            return View(arme);
        }

        // GET: Arme/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arme arme = db.arme.Find(id);
            if (arme == null)
            {
                return HttpNotFound();
            }
            return View(arme);
        }

        // POST: Arme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            arme arme = db.arme.Find(id);
            db.arme.Remove(arme);
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
