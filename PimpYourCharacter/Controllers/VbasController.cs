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
    public class VbasController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Vbas
        public ActionResult Index()
        {
            var vbas = db.vbas.Include(v => v.couleur).Include(v => v.texture);
            return View(vbas.ToList());
        }

        // GET: Vbas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vbas vbas = db.vbas.Find(id);
            if (vbas == null)
            {
                return HttpNotFound();
            }
            return View(vbas);
        }

        // GET: Vbas/Create
        public ActionResult Create()
        {
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label");
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label");
            return View();
        }

        // POST: Vbas/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_vbas,label,poids,id_texture,id_couleur")] vbas vbas)
        {
            if (ModelState.IsValid)
            {
                db.vbas.Add(vbas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label",vbas.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label",vbas.id_texture);
            
            return View(vbas);
        }

        // GET: Vbas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vbas vbas = db.vbas.Find(id);
            if (vbas == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vbas.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vbas.id_texture);
            return View(vbas);
        }

        // POST: Vbas/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_vbas,label,poids,id_texture,id_couleur")] vbas vbas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vbas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vbas.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vbas.id_texture);
            return View(vbas);
        }

        // GET: Vbas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vbas vbas = db.vbas.Find(id);
            if (vbas == null)
            {
                return HttpNotFound();
            }
            return View(vbas);
        }

        // POST: Vbas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vbas vbas = db.vbas.Find(id);
            db.vbas.Remove(vbas);
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