//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFSERVICEFSS
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTim()
        {
            this.tblIgracs = new HashSet<tblIgrac>();
            this.tblTreners = new HashSet<tblTrener>();
        }
    
        public int ID { get; set; }
        public string naziv { get; set; }
        public string sediste { get; set; }
        public string osnovan { get; set; }
        public int liga { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblIgrac> tblIgracs { get; set; }
        public virtual tblLiga tblLiga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTrener> tblTreners { get; set; }
    }
}
