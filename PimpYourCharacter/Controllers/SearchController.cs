using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PimpYourCharacter.Models;

namespace PimpYourCharacter.Controllers
{
    public class SearchController : Controller
    {

        private pimp_your_characterEntities db = new pimp_your_characterEntities();


        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult searchBouche(int id_bouche, String forme, int largeur, int hauteur, int profondeur, int id_couleur)
        {

            var requeteRecherche = from bou in db.bouche select bou;

            requeteRecherche = (id_bouche == -1) ? requeteRecherche : requeteRecherche.Where(bou => bou.id_bouche == id_bouche);
            requeteRecherche = (forme.CompareTo("") == 0 || forme == null) ? requeteRecherche : requeteRecherche.Where(bou => bou.forme.Contains(forme));
            requeteRecherche = (largeur == -1) ? requeteRecherche : requeteRecherche.Where(bou => bou.largeur == largeur);
            requeteRecherche = (hauteur == -1) ? requeteRecherche : requeteRecherche.Where(bou => bou.hauteur == hauteur);
            requeteRecherche = (profondeur == -1) ? requeteRecherche : requeteRecherche.Where(bou => bou.profondeur == profondeur);
            requeteRecherche = (id_couleur == -1) ? requeteRecherche : requeteRecherche.Where(bou => bou.id_couleur == id_couleur);

            foreach(var t in requeteRecherche)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5}", t.id_bouche,t.forme,t.largeur,t.hauteur,t.profondeur, t.id_couleur);
            }

            return View(requeteRecherche);
        }
    }
}