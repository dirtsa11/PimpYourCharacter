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
    public class CorpsController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Corps
        public ActionResult Index()
        {
            var corps = db.corps.Include(c => c.bras).Include(c => c.buste).Include(c => c.jambe).Include(c => c.tete);
            return View(corps.ToList());
        }

        // GET: Corps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            corps corps = db.corps.Find(id);
            if (corps == null)
            {
                return HttpNotFound();
            }
            return View(corps);
        }

        // GET: Corps/Create
        public ActionResult Create()
        {
            ViewBag.id_bras = new SelectList(db.bras, "id_bras", "forme");
            ViewBag.id_buste = new SelectList(db.buste, "id_buste", "id_buste");
            ViewBag.id_jambe = new SelectList(db.jambe, "id_jambe", "forme");
            ViewBag.id_tete = new SelectList(db.tete, "id_tete", "forme");
            return View();
        }

        // POST: Corps/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_corps,id_bras,id_jambe,id_buste,id_tete,taille")] corps corps)
        {
            if (ModelState.IsValid)
            {
                db.corps.Add(corps);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_bras = new SelectList(db.bras, "id_bras", "forme", corps.id_bras);
            ViewBag.id_buste = new SelectList(db.buste, "id_buste", "id_buste", corps.id_buste);
            ViewBag.id_jambe = new SelectList(db.jambe, "id_jambe", "forme", corps.id_jambe);
            ViewBag.id_tete = new SelectList(db.tete, "id_tete", "forme", corps.id_tete);
            return View(corps);
        }

        // GET: Corps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            corps corps = db.corps.Find(id);
            if (corps == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_bras = new SelectList(db.bras, "id_bras", "forme", corps.id_bras);
            ViewBag.id_buste = new SelectList(db.buste, "id_buste", "id_buste", corps.id_buste);
            ViewBag.id_jambe = new SelectList(db.jambe, "id_jambe", "forme", corps.id_jambe);
            ViewBag.id_tete = new SelectList(db.tete, "id_tete", "forme", corps.id_tete);
            return View(corps);
        }

        // POST: Corps/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_corps,id_bras,id_jambe,id_buste,id_tete,taille")] corps corps)
        {
            if (ModelState.IsValid)
            {
                db.Entry(corps).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_bras = new SelectList(db.bras, "id_bras", "forme", corps.id_bras);
            ViewBag.id_buste = new SelectList(db.buste, "id_buste", "id_buste", corps.id_buste);
            ViewBag.id_jambe = new SelectList(db.jambe, "id_jambe", "forme", corps.id_jambe);
            ViewBag.id_tete = new SelectList(db.tete, "id_tete", "forme", corps.id_tete);
            return View(corps);
        }

        // GET: Corps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            corps corps = db.corps.Find(id);
            if (corps == null)
            {
                return HttpNotFound();
            }
            return View(corps);
        }

        // POST: Corps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            corps corps = db.corps.Find(id);
            db.corps.Remove(corps);
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
