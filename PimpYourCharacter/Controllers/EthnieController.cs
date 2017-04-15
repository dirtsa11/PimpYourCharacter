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
    public class EthnieController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Ethnie
        public ActionResult Index()
        {

            SearchController test = new SearchController();
            test.searchBouche(-1, "", -1, -1, -1, -1);
            return View(db.ethnie.ToList());
        }

        // GET: Ethnie/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ethnie ethnie = db.ethnie.Find(id);
            if (ethnie == null)
            {
                return HttpNotFound();
            }
            return View(ethnie);
        }

        // GET: Ethnie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ethnie/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_ethnie,label")] ethnie ethnie)
        {
            if (ModelState.IsValid)
            {
                db.ethnie.Add(ethnie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ethnie);
        }

        // GET: Ethnie/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ethnie ethnie = db.ethnie.Find(id);
            if (ethnie == null)
            {
                return HttpNotFound();
            }
            return View(ethnie);
        }

        // POST: Ethnie/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_ethnie,label")] ethnie ethnie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ethnie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ethnie);
        }

        // GET: Ethnie/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ethnie ethnie = db.ethnie.Find(id);
            if (ethnie == null)
            {
                return HttpNotFound();
            }
            return View(ethnie);
        }

        // POST: Ethnie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ethnie ethnie = db.ethnie.Find(id);
            db.ethnie.Remove(ethnie);
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
