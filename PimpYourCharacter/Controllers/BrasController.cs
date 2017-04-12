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
    public class BrasController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Bras
        public ActionResult Index()
        {
            return View(db.bras.ToList());
        }

        // GET: Bras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bras bras = db.bras.Find(id);
            if (bras == null)
            {
                return HttpNotFound();
            }
            return View(bras);
        }

        // GET: Bras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bras/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_bras,longueur,forme")] bras bras)
        {
            if (ModelState.IsValid)
            {
                db.bras.Add(bras);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bras);
        }

        // GET: Bras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bras bras = db.bras.Find(id);
            if (bras == null)
            {
                return HttpNotFound();
            }
            return View(bras);
        }

        // POST: Bras/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_bras,longueur,forme")] bras bras)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bras).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bras);
        }

        // GET: Bras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bras bras = db.bras.Find(id);
            if (bras == null)
            {
                return HttpNotFound();
            }
            return View(bras);
        }

        // POST: Bras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bras bras = db.bras.Find(id);
            db.bras.Remove(bras);
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
