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
    public class TextureController : Controller
    {
        private pimp_your_characterEntities db = new pimp_your_characterEntities();

        // GET: Texture
        public ActionResult Index()
        {
            return View(db.texture.ToList());
        }

        // GET: Texture/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            texture texture = db.texture.Find(id);
            if (texture == null)
            {
                return HttpNotFound();
            }
            return View(texture);
        }

        // GET: Texture/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Texture/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_texture,label")] texture texture)
        {
            if (ModelState.IsValid)
            {
                db.texture.Add(texture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(texture);
        }

        // GET: Texture/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            texture texture = db.texture.Find(id);
            if (texture == null)
            {
                return HttpNotFound();
            }
            return View(texture);
        }

        // POST: Texture/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_texture,label")] texture texture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(texture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(texture);
        }

        // GET: Texture/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            texture texture = db.texture.Find(id);
            if (texture == null)
            {
                return HttpNotFound();
            }
            return View(texture);
        }

        // POST: Texture/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            texture texture = db.texture.Find(id);
            db.texture.Remove(texture);
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
