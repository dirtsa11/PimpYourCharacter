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
    public class CategorieAccessController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: CategorieAccess
        public ActionResult Index()
        {
            return View(db.categorie_accessoire.ToList());
        }

        // GET: CategorieAccess/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categorie_accessoire categorie_accessoire = db.categorie_accessoire.Find(id);
            if (categorie_accessoire == null)
            {
                return HttpNotFound();
            }
            return View(categorie_accessoire);
        }

        // GET: CategorieAccess/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategorieAccess/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_categorie_accessoire,label")] categorie_accessoire categorie_accessoire)
        {
            if (ModelState.IsValid)
            {
                db.categorie_accessoire.Add(categorie_accessoire);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categorie_accessoire);
        }

        // GET: CategorieAccess/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categorie_accessoire categorie_accessoire = db.categorie_accessoire.Find(id);
            if (categorie_accessoire == null)
            {
                return HttpNotFound();
            }
            return View(categorie_accessoire);
        }

        // POST: CategorieAccess/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_categorie_accessoire,label")] categorie_accessoire categorie_accessoire)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categorie_accessoire).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categorie_accessoire);
        }

        // GET: CategorieAccess/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categorie_accessoire categorie_accessoire = db.categorie_accessoire.Find(id);
            if (categorie_accessoire == null)
            {
                return HttpNotFound();
            }
            return View(categorie_accessoire);
        }

        // POST: CategorieAccess/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            categorie_accessoire categorie_accessoire = db.categorie_accessoire.Find(id);
            db.categorie_accessoire.Remove(categorie_accessoire);
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
