using PimpYourCharacter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PimpYourCharacter.ViewModel
{
    public class PersonnageViewModel
    {
        public personnage personnage { get; set; }
        public IEnumerable<SelectListItem> allAccessoires { get; set; }
        public IEnumerable<SelectListItem> allArmes { get; set; }
        public IEnumerable<SelectListItem> allBoucliers { get; set; }
        public IEnumerable<SelectListItem> allVMains { get; set; }
        public IEnumerable<SelectListItem> allVPieds { get; set; }
        public IEnumerable<SelectListItem> allVTetes { get; set; }

        private List<int> _selectedAccessoires;
        public List<int> SelectedAccessoires
        {
            get
            {
                if (_selectedAccessoires == null)
                {
                    _selectedAccessoires = personnage.accessoire.Select(m => m.id_accessoire).ToList();
                }
                return _selectedAccessoires;
            }
            set { _selectedAccessoires = value; }
        }

        private List<int> _selectedArmes;
        public List<int> SelectedArmes
        {
            get
            {
                if (_selectedArmes == null)
                {
                    _selectedArmes = personnage.arme.Select(m => m.id_arme).ToList();
                }
                return _selectedArmes;
            }
            set { _selectedArmes = value; }
        }

        private List<int> _selectedBoucliers;
        public List<int> SelectedBoucliers
        {
            get
            {
                if (_selectedBoucliers == null)
                {
                    _selectedBoucliers = personnage.bouclier.Select(m => m.id_bouclier).ToList();
                }
                return _selectedBoucliers;
            }
            set { _selectedBoucliers = value; }
        }

        private List<int> _selectedVMains;
        public List<int> SelectedVMains
        {
            get
            {
                if (_selectedVMains == null)
                {
                    _selectedVMains = personnage.vmain.Select(m => m.id_vmain).ToList();
                }
                return _selectedVMains;
            }
            set { _selectedVMains = value; }
        }

        private List<int> _selectedVPieds;
        public List<int> SelectedVPieds
        {
            get
            {
                if (_selectedVPieds == null)
                {
                    _selectedVPieds = personnage.vpied.Select(m => m.id_vpied).ToList();
                }
                return _selectedVPieds;
            }
            set { _selectedVPieds = value; }
        }

        private List<int> _selectedVTetes;
        public List<int> SelectedVTetes
        {
            get
            {
                if (_selectedVTetes == null)
                {
                    _selectedVTetes = personnage.vtete.Select(m => m.id_vtete).ToList();
                }
                return _selectedVTetes;
            }
            set { _selectedVTetes = value; }
        }
    }
}