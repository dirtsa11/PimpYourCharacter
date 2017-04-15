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
    public class AccessoireController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Accessoire
        public ActionResult Index()
        {
            var accessoire = db.accessoire.Include(a => a.categorie_accessoire);
            return View(accessoire.ToList());
        }

        // GET: Accessoire/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            accessoire accessoire = db.accessoire.Find(id);
            if (accessoire == null)
            {
                return HttpNotFound();
            }
            return View(accessoire);
        }

        // GET: Accessoire/Create
        public ActionResult Create()
        {
            ViewBag.id_categorie_accessoire = new SelectList(db.categorie_accessoire, "id_categorie_accessoire", "label");
            return View();
        }

        // POST: Accessoire/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_accessoire,label,id_categorie_accessoire")] accessoire accessoire)
        {
            if (ModelState.IsValid)
            {
                db.accessoire.Add(accessoire);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_categorie_accessoire = new SelectList(db.categorie_accessoire, "id_categorie_accessoire", "label", accessoire.id_categorie_accessoire);
            return View(accessoire);
        }

        // GET: Accessoire/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            accessoire accessoire = db.accessoire.Find(id);
            if (accessoire == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_categorie_accessoire = new SelectList(db.categorie_accessoire, "id_categorie_accessoire", "label", accessoire.id_categorie_accessoire);
            return View(accessoire);
        }

        // POST: Accessoire/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_accessoire,label,id_categorie_accessoire")] accessoire accessoire)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessoire).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_categorie_accessoire = new SelectList(db.categorie_accessoire, "id_categorie_accessoire", "label", accessoire.id_categorie_accessoire);
            return View(accessoire);
        }

        // GET: Accessoire/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            accessoire accessoire = db.accessoire.Find(id);
            if (accessoire == null)
            {
                return HttpNotFound();
            }
            return View(accessoire);
        }

        // POST: Accessoire/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            accessoire accessoire = db.accessoire.Find(id);
            db.accessoire.Remove(accessoire);
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
