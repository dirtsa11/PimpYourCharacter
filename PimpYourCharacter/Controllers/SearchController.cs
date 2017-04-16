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

        public ActionResult searchAccessoire(int id_accessoire, String label, int id_categorie)  {

            var requeteRecherche = from acc in db.accessoire select acc;

            requeteRecherche = (id_accessoire < 0) ? requeteRecherche : requeteRecherche.Where(acc => acc.id_accessoire == id_accessoire);
            requeteRecherche = (label.CompareTo("") == 0 || label == null) ? requeteRecherche : requeteRecherche.Where(acc => acc.label.Contains(label));
            requeteRecherche = (id_categorie < 0) ? requeteRecherche : requeteRecherche.Where(acc => acc.id_categorie_accessoire == id_categorie);

            return View(requeteRecherche);
        }

        public ActionResult searchArme(int id_arme, string label, int poids, int id_categorie) {

            var requeteRecherche = from arm in db.arme select arm;

            requeteRecherche = (id_arme < 0) ? requeteRecherche : requeteRecherche.Where(arm => arm.id_arme == id_arme);
            requeteRecherche = (label.CompareTo("") == 0 || label == null) ? requeteRecherche : requeteRecherche.Where(arm => arm.label.Contains(label));
            requeteRecherche = (poids < 0) ? requeteRecherche : requeteRecherche.Where(arm => arm.poids == poids);
            requeteRecherche = (id_categorie < 0) ? requeteRecherche : requeteRecherche.Where(arm => arm.id_categorie_arme == id_categorie);

            return View(requeteRecherche);
        }

        public ActionResult searchBouche(int id_bouche, String forme, int largeur, int hauteur, int profondeur, int id_couleur) {

            var requeteRecherche = from bou in db.bouche select bou;

            requeteRecherche = (id_bouche < 0) ? requeteRecherche : requeteRecherche.Where(bou => bou.id_bouche == id_bouche);
            requeteRecherche = (forme.CompareTo("") == 0 || forme == null) ? requeteRecherche : requeteRecherche.Where(bou => bou.forme.Contains(forme));
            requeteRecherche = (largeur < 0) ? requeteRecherche : requeteRecherche.Where(bou => bou.largeur == largeur);
            requeteRecherche = (hauteur < 0) ? requeteRecherche : requeteRecherche.Where(bou => bou.hauteur == hauteur);
            requeteRecherche = (profondeur < 0) ? requeteRecherche : requeteRecherche.Where(bou => bou.profondeur == profondeur);
            requeteRecherche = (id_couleur < 0) ? requeteRecherche : requeteRecherche.Where(bou => bou.id_couleur == id_couleur);

            return View(requeteRecherche);
        }

        public ActionResult searchBouclier(int id_bouclier, string label, int poids) {

            var requeteRecherche = from bou in db.bouclier select bou;

            requeteRecherche = (id_bouclier < 0) ? requeteRecherche : requeteRecherche.Where(bou => bou.id_bouclier == id_bouclier);
            requeteRecherche = (label.CompareTo("") == 0 || label == null) ? requeteRecherche : requeteRecherche.Where(bou => bou.label.Contains(label));
            requeteRecherche = (poids < 0) ? requeteRecherche : requeteRecherche.Where(bou => bou.poids == poids);

            return View(requeteRecherche);
        }

        public ActionResult searchBras(int id_bras, int longueur, string forme) {

            var requeteRecherche = from bra in db.bras select bra;

            requeteRecherche = (id_bras < 0) ? requeteRecherche : requeteRecherche.Where(bra => bra.id_bras == id_bras);
            requeteRecherche = (forme.CompareTo("") == 0 || forme == null) ? requeteRecherche : requeteRecherche.Where(bra => bra.forme.Contains(forme));
            requeteRecherche = (longueur < 0) ? requeteRecherche : requeteRecherche.Where(bra => bra.longueur == longueur);

            return View(requeteRecherche);
        }

        public ActionResult searchBuste(int id_buste, int hauteur, int largeur, int corpulence) {

            var requeteRecherche = from bus in db.buste select bus;

            requeteRecherche = (id_buste < 0) ? requeteRecherche :requeteRecherche.Where(bus => bus.id_buste == id_buste);
            requeteRecherche = (hauteur < 0) ? requeteRecherche :requeteRecherche.Where(bus => bus.hauteur == hauteur);
            requeteRecherche = (largeur < 0) ? requeteRecherche : requeteRecherche.Where(bus => bus.largeur == largeur);
            requeteRecherche = (corpulence < 0) ? requeteRecherche : requeteRecherche.Where(bus => bus.corpulence == corpulence);


            return View(requeteRecherche);
        }

        public ActionResult searchCorps(int id_corps, int id_bras, int id_jambe, int id_buste, int id_tete, int taille) {

            var requeteRecherche = from cor in db.corps select cor;

            requeteRecherche = (id_corps < 0) ? requeteRecherche : requeteRecherche.Where(cor => cor.id_corps == id_corps);
            requeteRecherche = (id_bras < 0) ? requeteRecherche : requeteRecherche.Where(cor => cor.id_bras == id_bras);
            requeteRecherche = (id_jambe < 0) ? requeteRecherche : requeteRecherche.Where(cor => cor.id_jambe == id_jambe);
            requeteRecherche = (id_buste < 0) ? requeteRecherche : requeteRecherche.Where(cor => cor.id_buste == id_buste);
            requeteRecherche = (id_tete < 0) ? requeteRecherche : requeteRecherche.Where(cor => cor.id_tete == id_tete);
            requeteRecherche = (taille < 0) ? requeteRecherche : requeteRecherche.Where(cor => cor.taille == taille);

            return View(requeteRecherche);
        }

        public ActionResult searchCouleur(int id_couleur, string label) {

            var requeteRecherche = from cou in db.couleur select cou;

            requeteRecherche = (id_couleur < 0) ? requeteRecherche : requeteRecherche.Where(cou => cou.id_couleur == id_couleur);
            requeteRecherche = (label.CompareTo("") == 0 || label == null) ? requeteRecherche : requeteRecherche.Where(cou => cou.label.Contains(label));

            return View(requeteRecherche);
        }

        public ActionResult searchEthnie(int id_ethnie, string label)
        {

            var requeteRecherche = from eth in db.ethnie select eth;

            requeteRecherche = (id_ethnie < 0) ? requeteRecherche : requeteRecherche.Where(eth => eth.id_ethnie == id_ethnie);
            requeteRecherche = (label.CompareTo("") == 0 || label == null) ? requeteRecherche : requeteRecherche.Where(eth => eth.label.Contains(label));

            return View(requeteRecherche);
        }

        public ActionResult searchJambe(int id_jambe, int hauteur, string forme)
        {

            var requeteRecherche = from jam in db.jambe select jam;

            requeteRecherche = (id_jambe < 0) ? requeteRecherche : requeteRecherche.Where(jam => jam.id_jambe == id_jambe);
            requeteRecherche = (hauteur < 0) ? requeteRecherche : requeteRecherche.Where(jam => jam.hauteur == hauteur);
            requeteRecherche = (forme.CompareTo("") == 0 || forme == null) ? requeteRecherche : requeteRecherche.Where(jam => jam.forme.Contains(forme));

            return View(requeteRecherche);
        }

        public ActionResult searchNez(int id_nez,int hauteur, int largeur, int profondeur, string forme)
        {

            var requeteRecherche = from nez in db.nez select nez;

            requeteRecherche = (id_nez < 0) ? requeteRecherche : requeteRecherche.Where(nez => nez.id_nez == id_nez);
            requeteRecherche = (hauteur < 0) ? requeteRecherche : requeteRecherche.Where(nez => nez.hauteur == hauteur);
            requeteRecherche = (largeur < 0) ? requeteRecherche : requeteRecherche.Where(nez => nez.largeur == largeur);
            requeteRecherche = (profondeur < 0) ? requeteRecherche : requeteRecherche.Where(nez => nez.profondeur == profondeur);
            requeteRecherche = (forme.CompareTo("") == 0 || forme == null) ? requeteRecherche : requeteRecherche.Where(nez => nez.forme.Contains(forme));

            return View(requeteRecherche);
        }

        public ActionResult searchPersonnage(int id_personnage, string nom, int age, int id_ethnie, int id_genre, int vbas, int vhaut, int id_corps)
        {

            var requeteRecherche = from per in db.personnage select per;

            requeteRecherche = (id_personnage < 0) ? requeteRecherche : requeteRecherche.Where(per => per.id_personnage == id_personnage);
            requeteRecherche = (nom.CompareTo("") == 0 || nom == null) ? requeteRecherche : requeteRecherche.Where(per => per.nom.Contains(nom));
            requeteRecherche = (age < 0) ? requeteRecherche : requeteRecherche.Where(per => per.age == age);
            requeteRecherche = (id_ethnie < 0) ? requeteRecherche : requeteRecherche.Where(per => per.id_ethnie == id_ethnie);
            requeteRecherche = (id_genre < 0) ? requeteRecherche : requeteRecherche.Where(per => per.id_genre == id_genre);
            requeteRecherche = (vbas < 0) ? requeteRecherche : requeteRecherche.Where(per => per.vbas.id_vbas == vbas);
            requeteRecherche = (vhaut < 0) ? requeteRecherche : requeteRecherche.Where(per => per.vhaut.id_vhaut == vhaut);
            requeteRecherche = (id_corps < 0) ? requeteRecherche : requeteRecherche.Where(per => per.id_corps == id_corps);

            return View(requeteRecherche);
        }

        public ActionResult searchTete(int id_tete, int id_nez, int id_bouche, int id_yeux, int hauteur, int largeur, string forme)
        {

            var requeteRecherche = from tet in db.tete select tet;

            requeteRecherche = (id_tete < 0) ? requeteRecherche : requeteRecherche.Where(tet => tet.id_tete == id_tete);
            requeteRecherche = (id_nez < 0) ? requeteRecherche : requeteRecherche.Where(tet => tet.id_nez == id_nez);
            requeteRecherche = (id_bouche < 0) ? requeteRecherche : requeteRecherche.Where(tet => tet.id_bouche == id_bouche);
            requeteRecherche = (id_yeux < 0) ? requeteRecherche : requeteRecherche.Where(tet => tet.id_yeux == id_yeux);
            requeteRecherche = (hauteur < 0) ? requeteRecherche : requeteRecherche.Where(tet => tet.hauteur == hauteur);
            requeteRecherche = (largeur < 0) ? requeteRecherche : requeteRecherche.Where(tet => tet.largeur == largeur);
            requeteRecherche = (forme.CompareTo("") == 0 || forme == null) ? requeteRecherche : requeteRecherche.Where(tet => tet.forme.Contains(forme));

            return View(requeteRecherche);
        }

        public ActionResult searchTexture(int id_texture, string label)
        {

            var requeteRecherche = from tex in db.texture select tex;

            requeteRecherche = (id_texture < 0) ? requeteRecherche : requeteRecherche.Where(tex => tex.id_texture == id_texture);
            requeteRecherche = (label.CompareTo("") == 0 || label == null) ? requeteRecherche : requeteRecherche.Where(tex => tex.label.Contains(label));

            return View(requeteRecherche);
        }

        public ActionResult searchYeux(int id_yeux, string forme, int hauteur, int largeur, int profondeur, int ecartement, int id_couleur)
        {

            var requeteRecherche = from yeu in db.yeux select yeu;

            requeteRecherche = (id_yeux < 0) ? requeteRecherche : requeteRecherche.Where(yeu => yeu.id_yeux == id_yeux);
            requeteRecherche = (forme.CompareTo("") == 0 || forme == null) ? requeteRecherche : requeteRecherche.Where(yeu => yeu.forme.Contains(forme));
            requeteRecherche = (hauteur < 0) ? requeteRecherche : requeteRecherche.Where(yeu => yeu.hauteur == hauteur);
            requeteRecherche = (largeur < 0) ? requeteRecherche : requeteRecherche.Where(yeu => yeu.largeur == largeur);
            requeteRecherche = (profondeur < 0) ? requeteRecherche : requeteRecherche.Where(yeu => yeu.profondeur == profondeur);
            requeteRecherche = (ecartement < 0) ? requeteRecherche : requeteRecherche.Where(yeu => yeu.ecartement == ecartement);
            requeteRecherche = (id_couleur < 0) ? requeteRecherche : requeteRecherche.Where(yeu => yeu.id_couleur == id_couleur);

            return View(requeteRecherche);
        }
    }
}