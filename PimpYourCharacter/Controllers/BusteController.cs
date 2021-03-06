﻿using System;
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
    public class BusteController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Buste
        public ActionResult Index()
        {
            return View(db.buste.ToList());
        }

        // GET: Buste/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            buste buste = db.buste.Find(id);
            if (buste == null)
            {
                return HttpNotFound();
            }
            return View(buste);
        }

        // GET: Buste/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buste/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_buste,hauteur,largeur,corpulence")] buste buste)
        {
            if (ModelState.IsValid)
            {
                db.buste.Add(buste);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(buste);
        }

        // GET: Buste/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            buste buste = db.buste.Find(id);
            if (buste == null)
            {
                return HttpNotFound();
            }
            return View(buste);
        }

        // POST: Buste/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_buste,hauteur,largeur,corpulence")] buste buste)
        {
            if (ModelState.IsValid)
            {
                db.Entry(buste).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(buste);
        }

        // GET: Buste/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            buste buste = db.buste.Find(id);
            if (buste == null)
            {
                return HttpNotFound();
            }
            return View(buste);
        }

        // POST: Buste/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            buste buste = db.buste.Find(id);
            db.buste.Remove(buste);
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
