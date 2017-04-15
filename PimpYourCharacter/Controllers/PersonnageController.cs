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
    public class PersonnageController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Personnage
        public ActionResult Index()
        {
            var personnage = db.personnage.Include(p => p.corps).Include(p => p.ethnie).Include(p => p.genre).Include(p => p.vbas).Include(p => p.vhaut);
            return View(personnage.ToList());
        }

        // GET: Personnage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            personnage personnage = db.personnage.Find(id);
            if (personnage == null)
            {
                return HttpNotFound();
            }
            return View(personnage);
        }

        // GET: Personnage/Create
        public ActionResult Create()
        {
            ViewBag.id_corps = new SelectList(db.corps, "id_corps", "id_corps");
            ViewBag.id_ethnie = new SelectList(db.ethnie, "id_ethnie", "label");
            ViewBag.id_genre = new SelectList(db.genre, "id_genre", "label");
            ViewBag.id_vbas = new SelectList(db.vbas, "id_vbas", "label");
            ViewBag.id_vhaut = new SelectList(db.vhaut, "id_vhaut", "label");
            return View();
        }

        // POST: Personnage/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_personnage,nom,age,id_ethnie,id_genre,id_vbas,id_vhaut,id_corps")] personnage personnage)
        {
            if (ModelState.IsValid)
            {
                db.personnage.Add(personnage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_corps = new SelectList(db.corps, "id_corps", "id_corps", personnage.id_corps);
            ViewBag.id_ethnie = new SelectList(db.ethnie, "id_ethnie", "label", personnage.id_ethnie);
            ViewBag.id_genre = new SelectList(db.genre, "id_genre", "label", personnage.id_genre);
            ViewBag.id_vbas = new SelectList(db.vbas, "id_vbas", "label", personnage.id_vbas);
            ViewBag.id_vhaut = new SelectList(db.vhaut, "id_vhaut", "label", personnage.id_vhaut);
            return View(personnage);
        }

        // GET: Personnage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            personnage personnage = db.personnage.Find(id);
            if (personnage == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_corps = new SelectList(db.corps, "id_corps", "id_corps", personnage.id_corps);
            ViewBag.id_ethnie = new SelectList(db.ethnie, "id_ethnie", "label", personnage.id_ethnie);
            ViewBag.id_genre = new SelectList(db.genre, "id_genre", "label", personnage.id_genre);
            ViewBag.id_vbas = new SelectList(db.vbas, "id_vbas", "label", personnage.id_vbas);
            ViewBag.id_vhaut = new SelectList(db.vhaut, "id_vhaut", "label", personnage.id_vhaut);
            return View(personnage);
        }

        // POST: Personnage/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_personnage,nom,age,id_ethnie,id_genre,id_vbas,id_vhaut,id_corps")] personnage personnage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personnage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_corps = new SelectList(db.corps, "id_corps", "id_corps", personnage.id_corps);
            ViewBag.id_ethnie = new SelectList(db.ethnie, "id_ethnie", "label", personnage.id_ethnie);
            ViewBag.id_genre = new SelectList(db.genre, "id_genre", "label", personnage.id_genre);
            ViewBag.id_vbas = new SelectList(db.vbas, "id_vbas", "label", personnage.id_vbas);
            ViewBag.id_vhaut = new SelectList(db.vhaut, "id_vhaut", "label", personnage.id_vhaut);
            return View(personnage);
        }

        // GET: Personnage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            personnage personnage = db.personnage.Find(id);
            if (personnage == null)
            {
                return HttpNotFound();
            }
            return View(personnage);
        }

        // POST: Personnage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            personnage personnage = db.personnage.Find(id);
            db.personnage.Remove(personnage);
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
