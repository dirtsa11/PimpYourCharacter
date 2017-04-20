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
    public class VteteController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Vtete
        public ActionResult Index()
        {
            var vtete = db.vtete.Include(v => v.couleur).Include(v => v.texture);
            return View(vtete.ToList());
        }

        // GET: Vtete/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vtete vtete = db.vtete.Find(id);
            if (vtete == null)
            {
                return HttpNotFound();
            }
            return View(vtete);
        }

        // GET: Vtete/Create
        public ActionResult Create()
        {
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label");
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label");
            return View();
        }

        // POST: Vtete/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_vtete,label,poids,id_texture,id_couleur")] vtete vtete)
        {
            if (ModelState.IsValid)
            {
                db.vtete.Add(vtete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vtete.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vtete.id_texture);

            return View(vtete);
        }

        // GET: Vtete/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vtete vtete = db.vtete.Find(id);
            if (vtete == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vtete.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vtete.id_texture);
            return View(vtete);
        }

        // POST: Vtete/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_vtete,label,poids,id_texture,id_couleur")] vtete vtete)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vtete).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vtete.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vtete.id_texture);
            return View(vtete);
        }

        // GET: Vtete/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vtete vtete = db.vtete.Find(id);
            if (vtete == null)
            {
                return HttpNotFound();
            }
            return View(vtete);
        }

        // POST: Vtete/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vtete vtete = db.vtete.Find(id);
            db.vtete.Remove(vtete);
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
