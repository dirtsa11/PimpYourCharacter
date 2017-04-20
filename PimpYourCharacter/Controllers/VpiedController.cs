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
    public class VpiedController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Vpied
        public ActionResult Index()
        {
            var vpied = db.vpied.Include(v => v.couleur).Include(v => v.texture);
            return View(vpied.ToList());
        }

        // GET: Vpied/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vpied vpied = db.vpied.Find(id);
            if (vpied == null)
            {
                return HttpNotFound();
            }
            return View(vpied);
        }

        // GET: Vpied/Create
        public ActionResult Create()
        {
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label");
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label");
            return View();
        }

        // POST: Vpied/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_vpied,label,poids,id_texture,id_couleur")] vpied vpied)
        {
            if (ModelState.IsValid)
            {
                db.vpied.Add(vpied);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vpied.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vpied.id_texture);

            return View(vpied);
        }

        // GET: Vpied/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vpied vpied = db.vpied.Find(id);
            if (vpied == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vpied.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vpied.id_texture);
            return View(vpied);
        }

        // POST: Vpied/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_vpied,label,poids,id_texture,id_couleur")] vpied vpied)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vpied).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vpied.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vpied.id_texture);
            return View(vpied);
        }

        // GET: Vpied/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vpied vpied = db.vpied.Find(id);
            if (vpied == null)
            {
                return HttpNotFound();
            }
            return View(vpied);
        }

        // POST: Vpied/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vpied vpied = db.vpied.Find(id);
            db.vpied.Remove(vpied);
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
