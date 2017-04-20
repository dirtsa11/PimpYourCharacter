using System;
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
    public class VhautController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Vhaut
        public ActionResult Index()
        {
            var vhaut = db.vhaut.Include(v => v.couleur).Include(v => v.texture);
            return View(vhaut.ToList());
        }

        // GET: Vhaut/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vhaut vhaut = db.vhaut.Find(id);
            if (vhaut == null)
            {
                return HttpNotFound();
            }
            return View(vhaut);
        }

        // GET: Vhaut/Create
        public ActionResult Create()
        {
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label");
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label");
            return View();
        }

        // POST: Vhaut/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_vhaut,label,poids,id_texture,id_couleur")] vhaut vhaut)
        {
            if (ModelState.IsValid)
            {
                db.vhaut.Add(vhaut);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vhaut.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vhaut.id_texture);

            return View(vhaut);
        }

        // GET: Vhaut/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vhaut vhaut = db.vhaut.Find(id);
            if (vhaut == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vhaut.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vhaut.id_texture);
            return View(vhaut);
        }

        // POST: Vhaut/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_vhaut,label,poids,id_texture,id_couleur")] vhaut vhaut)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vhaut).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vhaut.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vhaut.id_texture);
            return View(vhaut);
        }

        // GET: Vhaut/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vhaut vhaut = db.vhaut.Find(id);
            if (vhaut == null)
            {
                return HttpNotFound();
            }
            return View(vhaut);
        }

        // POST: Vhaut/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vhaut vhaut = db.vhaut.Find(id);
            db.vhaut.Remove(vhaut);
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
