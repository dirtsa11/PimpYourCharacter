//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PimpYourCharacter.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vpied
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vpied()
        {
            this.personnage = new HashSet<personnage>();
        }
    
        public int id_vpied { get; set; }
        public string label { get; set; }
        public int poids { get; set; }
        public int id_texture { get; set; }
        public int id_couleur { get; set; }
    
        public virtual couleur couleur { get; set; }
        public virtual texture texture { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personnage> personnage { get; set; }
    }
}
