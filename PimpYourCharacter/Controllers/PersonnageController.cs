using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PimpYourCharacter.Models;
using PimpYourCharacter.ViewModel;

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

            var personnageViewModel = new PersonnageViewModel
            {
                personnage = db.personnage.Include(i => i.accessoire).Include(i => i.arme).Include(i => i.bouclier).Include(i => i.vmain).Include(i => i.vpied).Include(i => i.vtete).First(i => i.id_personnage == id),
            };

            if (personnageViewModel.personnage == null)
            {
                return HttpNotFound();
            }

            var allAccessoiresList = db.accessoire.ToList();
            personnageViewModel.allAccessoires = allAccessoiresList.Select(o => new SelectListItem
            {
                Text = o.label,
                Value = o.id_accessoire.ToString()
            });

            var allArmesList = db.arme.ToList();
            personnageViewModel.allArmes = allArmesList.Select(o => new SelectListItem
            {
                Text = o.label,
                Value = o.id_arme.ToString()
            });

            var allBoucliersList = db.bouclier.ToList();
            personnageViewModel.allBoucliers = allBoucliersList.Select(o => new SelectListItem
            {
                Text = o.label,
                Value = o.id_bouclier.ToString()
            });

            var allVMainsList = db.vmain.ToList();
            personnageViewModel.allVMains = allVMainsList.Select(o => new SelectListItem
            {
                Text = o.label,
                Value = o.id_vmain.ToString()
            });

            var allVPiedsList = db.vpied.ToList();
            personnageViewModel.allVPieds = allVPiedsList.Select(o => new SelectListItem
            {
                Text = o.label,
                Value = o.id_vpied.ToString()
            });

            var allVTetesList = db.vtete.ToList();
            personnageViewModel.allVTetes = allVTetesList.Select(o => new SelectListItem
            {
                Text = o.label,
                Value = o.id_vtete.ToString()
            });

            ViewBag.id_corps = new SelectList(db.corps, "id_corps", "id_corps", personnageViewModel.personnage.id_corps);
            ViewBag.id_ethnie = new SelectList(db.ethnie, "id_ethnie", "label", personnageViewModel.personnage.id_ethnie);
            ViewBag.id_genre = new SelectList(db.genre, "id_genre", "label", personnageViewModel.personnage.id_genre);
            ViewBag.id_vbas = new SelectList(db.vbas, "id_vbas", "label", personnageViewModel.personnage.id_vbas);
            ViewBag.id_vhaut = new SelectList(db.vhaut, "id_vhaut", "label", personnageViewModel.personnage.id_vhaut);

            return View(personnageViewModel);
        }

        // POST: Personnage/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken] //[Bind(Include = "nom,age,id_ethnie,id_genre,id_vbas,id_vhaut,id_corps,SelectedAccessoires,SelectedArmes,SelectedBoucleirs,SelectedVMains,SelectedVPieds,SelectedVtetes")]
        public ActionResult Edit(PersonnageViewModel personnageView)
        {
            if (personnageView == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            if (ModelState.IsValid)
            {
                var personnageToUpdate = db.personnage.Include(i => i.accessoire).Include(i => i.arme).Include(i => i.bouclier).Include(i => i.vmain).Include(i => i.vpied).Include(i => i.vtete).First(i => i.id_personnage == personnageView.personnage.id_personnage);

                if (TryUpdateModel(personnageToUpdate, "personnage", new string[] { "nom,age,id_ethnie,id_genre,id_vbas,id_vhaut,id_corps" }))
                {
                    if (personnageView.personnage.nom != null)
                        personnageToUpdate.nom = personnageView.personnage.nom;
                    if (personnageView.personnage.age != 0)
                        personnageToUpdate.age = personnageView.personnage.age;

                    if (personnageView.personnage.id_ethnie != 0)
                        personnageToUpdate.id_ethnie = personnageView.personnage.id_ethnie;
                    if (personnageView.personnage.id_genre != 0)
                        personnageToUpdate.id_genre = personnageView.personnage.id_genre;
                    if (personnageView.personnage.id_vbas != 0)
                        personnageToUpdate.id_vbas = personnageView.personnage.id_vbas;
                    if (personnageView.personnage.id_vhaut != 0)
                        personnageToUpdate.id_vhaut = personnageView.personnage.id_vhaut;
                    if (personnageView.personnage.id_corps != 0)
                        personnageToUpdate.id_corps = personnageView.personnage.id_corps;

                    var newAccessoires = db.accessoire.Where(m => personnageView.SelectedAccessoires.Contains(m.id_accessoire)).ToList();
                    var updatedAccessoires = new HashSet<int>(personnageView.SelectedAccessoires);
                    foreach (accessoire acc in db.accessoire)
                    {
                        if (!updatedAccessoires.Contains(acc.id_accessoire))
                        {
                            personnageToUpdate.accessoire.Remove(acc);
                        }
                        else
                        {
                            personnageToUpdate.accessoire.Add((acc));
                        }
                    }

                    var newArmes = db.arme.Where(m => personnageView.SelectedArmes.Contains(m.id_arme)).ToList();
                    var updatedArmes = new HashSet<int>(personnageView.SelectedArmes);
                    foreach (arme arm in db.arme)
                    {
                        if (!updatedArmes.Contains(arm.id_arme))
                        {
                            personnageToUpdate.arme.Remove(arm);
                        }
                        else
                        {
                            personnageToUpdate.arme.Add((arm));
                        }
                    }

                    var newBoucliers = db.bouclier.Where(m => personnageView.SelectedBoucliers.Contains(m.id_bouclier)).ToList();
                    var updatedBoucliers = new HashSet<int>(personnageView.SelectedBoucliers);
                    foreach (bouclier bou in db.bouclier)
                    {
                        if (!updatedBoucliers.Contains(bou.id_bouclier))
                        {
                            personnageToUpdate.bouclier.Remove(bou);
                        }
                        else
                        {
                            personnageToUpdate.bouclier.Add((bou));
                        }
                    }

                    var newVMains = db.vmain.Where(m => personnageView.SelectedVMains.Contains(m.id_vmain)).ToList();
                    var updatedVMains = new HashSet<int>(personnageView.SelectedVMains);
                    foreach (vmain vm in db.vmain)
                    {
                        if (!updatedVMains.Contains(vm.id_vmain))
                        {
                            personnageToUpdate.vmain.Remove(vm);
                        }
                        else
                        {
                            personnageToUpdate.vmain.Add((vm));
                        }
                    }

                    var newVPieds = db.vpied.Where(m => personnageView.SelectedVPieds.Contains(m.id_vpied)).ToList();
                    var updatedVPieds = new HashSet<int>(personnageView.SelectedVPieds);
                    foreach (vpied vp in db.vpied)
                    {
                        if (!updatedVPieds.Contains(vp.id_vpied))
                        {
                            personnageToUpdate.vpied.Remove(vp);
                        }
                        else
                        {
                            personnageToUpdate.vpied.Add((vp));
                        }
                    }

                    var newVTetes = db.vtete.Where(m => personnageView.SelectedVTetes.Contains(m.id_vtete)).ToList();
                    var updatedVTetes = new HashSet<int>(personnageView.SelectedVTetes);
                    foreach (vtete vt in db.vtete)
                    {
                        if (!updatedVTetes.Contains(vt.id_vtete))
                        {
                            personnageToUpdate.vtete.Remove(vt);
                        }
                        else
                        {
                            personnageToUpdate.vtete.Add((vt));
                        }
                    }

                    db.Entry(personnageToUpdate).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }

            ViewBag.id_corps = new SelectList(db.corps, "id_corps", "id_corps", personnageView.personnage.id_corps);
            ViewBag.id_ethnie = new SelectList(db.ethnie, "id_ethnie", "label", personnageView.personnage.id_ethnie);
            ViewBag.id_genre = new SelectList(db.genre, "id_genre", "label", personnageView.personnage.id_genre);
            ViewBag.id_vbas = new SelectList(db.vbas, "id_vbas", "label", personnageView.personnage.id_vbas);
            ViewBag.id_vhaut = new SelectList(db.vhaut, "id_vhaut", "label", personnageView.personnage.id_vhaut);

            return View(personnageView);
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
