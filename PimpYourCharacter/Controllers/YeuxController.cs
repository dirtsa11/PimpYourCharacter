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
    public class YeuxController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Yeux
        public ActionResult Index()
        {
            var yeux = db.yeux.Include(y => y.couleur);
            return View(yeux.ToList());
        }

        // GET: Yeux/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            yeux yeux = db.yeux.Find(id);
            if (yeux == null)
            {
                return HttpNotFound();
            }
            return View(yeux);
        }

        // GET: Yeux/Create
        public ActionResult Create()
        {
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label");
            return View();
        }

        // POST: Yeux/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_yeux,forme,hauteur,largeur,profondeur,ecartement,id_couleur")] yeux yeux)
        {
            if (ModelState.IsValid)
            {
                db.yeux.Add(yeux);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", yeux.id_couleur);
            return View(yeux);
        }

        // GET: Yeux/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            yeux yeux = db.yeux.Find(id);
            if (yeux == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", yeux.id_couleur);
            return View(yeux);
        }

        // POST: Yeux/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_yeux,forme,hauteur,largeur,profondeur,ecartement,id_couleur")] yeux yeux)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yeux).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", yeux.id_couleur);
            return View(yeux);
        }

        // GET: Yeux/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            yeux yeux = db.yeux.Find(id);
            if (yeux == null)
            {
                return HttpNotFound();
            }
            return View(yeux);
        }

        // POST: Yeux/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            yeux yeux = db.yeux.Find(id);
            db.yeux.Remove(yeux);
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
