//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TTPV2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_ttp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_ttp()
        {
            this.Participants = new HashSet<Participants>();
        }
    
        public string UserName { get; set; }
        public string MailUser { get; set; }
        public string MdpUser { get; set; }
        public string NomUser { get; set; }
        public string PrenomUser { get; set; }
        public Nullable<int> AgeUser { get; set; }
        public string GenreUser { get; set; }
        public string TelUser { get; set; }
        public string PhotoUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participants> Participants { get; set; }
    }
}
