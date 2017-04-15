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
    public class CategorieArmeController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: CategorieArme
        public ActionResult Index()
        {
            return View(db.categorie_arme.ToList());
        }

        // GET: CategorieArme/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categorie_arme categorie_arme = db.categorie_arme.Find(id);
            if (categorie_arme == null)
            {
                return HttpNotFound();
            }
            return View(categorie_arme);
        }

        // GET: CategorieArme/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategorieArme/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_categorie_arme,categorie_arme1")] categorie_arme categorie_arme)
        {
            if (ModelState.IsValid)
            {
                db.categorie_arme.Add(categorie_arme);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categorie_arme);
        }

        // GET: CategorieArme/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categorie_arme categorie_arme = db.categorie_arme.Find(id);
            if (categorie_arme == null)
            {
                return HttpNotFound();
            }
            return View(categorie_arme);
        }

        // POST: CategorieArme/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_categorie_arme,categorie_arme1")] categorie_arme categorie_arme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categorie_arme).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categorie_arme);
        }

        // GET: CategorieArme/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categorie_arme categorie_arme = db.categorie_arme.Find(id);
            if (categorie_arme == null)
            {
                return HttpNotFound();
            }
            return View(categorie_arme);
        }

        // POST: CategorieArme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            categorie_arme categorie_arme = db.categorie_arme.Find(id);
            db.categorie_arme.Remove(categorie_arme);
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
