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
    
    public partial class corps
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public corps()
        {
            this.personnage = new HashSet<personnage>();
        }
    
        public int id_corps { get; set; }
        public int id_bras { get; set; }
        public int id_jambe { get; set; }
        public int id_buste { get; set; }
        public int id_tete { get; set; }
        public int taille { get; set; }
    
        public virtual bras bras { get; set; }
        public virtual buste buste { get; set; }
        public virtual jambe jambe { get; set; }
        public virtual tete tete { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personnage> personnage { get; set; }
    }
}
