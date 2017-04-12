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
    public class TeteController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Tete
        public ActionResult Index()
        {
            var tete = db.tete.Include(t => t.bouche).Include(t => t.nez).Include(t => t.yeux);
            return View(tete.ToList());
        }

        // GET: Tete/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tete tete = db.tete.Find(id);
            if (tete == null)
            {
                return HttpNotFound();
            }
            return View(tete);
        }

        // GET: Tete/Create
        public ActionResult Create()
        {
            ViewBag.id_bouche = new SelectList(db.bouche, "id_bouche", "forme");
            ViewBag.id_nez = new SelectList(db.nez, "id_nez", "forme");
            ViewBag.id_yeux = new SelectList(db.yeux, "id_yeux", "forme");
            return View();
        }

        // POST: Tete/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_tete,id_nez,id_bouche,id_yeux,hauteur,largeur,forme")] tete tete)
        {
            if (ModelState.IsValid)
            {
                db.tete.Add(tete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_bouche = new SelectList(db.bouche, "id_bouche", "forme", tete.id_bouche);
            ViewBag.id_nez = new SelectList(db.nez, "id_nez", "forme", tete.id_nez);
            ViewBag.id_yeux = new SelectList(db.yeux, "id_yeux", "forme", tete.id_yeux);
            return View(tete);
        }

        // GET: Tete/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tete tete = db.tete.Find(id);
            if (tete == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_bouche = new SelectList(db.bouche, "id_bouche", "forme", tete.id_bouche);
            ViewBag.id_nez = new SelectList(db.nez, "id_nez", "forme", tete.id_nez);
            ViewBag.id_yeux = new SelectList(db.yeux, "id_yeux", "forme", tete.id_yeux);
            return View(tete);
        }

        // POST: Tete/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_tete,id_nez,id_bouche,id_yeux,hauteur,largeur,forme")] tete tete)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tete).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_bouche = new SelectList(db.bouche, "id_bouche", "forme", tete.id_bouche);
            ViewBag.id_nez = new SelectList(db.nez, "id_nez", "forme", tete.id_nez);
            ViewBag.id_yeux = new SelectList(db.yeux, "id_yeux", "forme", tete.id_yeux);
            return View(tete);
        }

        // GET: Tete/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tete tete = db.tete.Find(id);
            if (tete == null)
            {
                return HttpNotFound();
            }
            return View(tete);
        }

        // POST: Tete/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tete tete = db.tete.Find(id);
            db.tete.Remove(tete);
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
