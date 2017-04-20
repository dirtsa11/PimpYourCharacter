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
    public class VmainController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Vmain
        public ActionResult Index()
        {
            var vmain = db.vmain.Include(v => v.couleur).Include(v => v.texture);
            return View(vmain.ToList());
        }

        // GET: Vmain/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vmain vmain = db.vmain.Find(id);
            if (vmain == null)
            {
                return HttpNotFound();
            }
            return View(vmain);
        }

        // GET: Vmain/Create
        public ActionResult Create()
        {
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label");
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label");
            return View();
        }

        // POST: Vmain/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_vmain,label,poids,id_texture,id_couleur")] vmain vmain)
        {
            if (ModelState.IsValid)
            {
                db.vmain.Add(vmain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vmain.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vmain.id_texture);

            return View(vmain);
        }


        // GET: Vmain/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vmain vmain = db.vmain.Find(id);
            if (vmain == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vmain.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vmain.id_texture);
            return View(vmain);
        }

        // POST: Vmain/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_vmain,label,poids,id_texture,id_couleur")] vmain vmain)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vmain).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_couleur = new SelectList(db.couleur, "id_couleur", "label", vmain.id_couleur);
            ViewBag.id_texture = new SelectList(db.texture, "id_texture", "label", vmain.id_texture);
            return View(vmain);
        }

        // GET: Vmain/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vmain vmain = db.vmain.Find(id);
            if (vmain == null)
            {
                return HttpNotFound();
            }
            return View(vmain);
        }

        // POST: Vmain/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vmain vmain = db.vmain.Find(id);
            db.vmain.Remove(vmain);
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
