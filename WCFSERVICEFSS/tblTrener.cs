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
    
    public partial class tblTrener
    {
        public int ID { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public int tim { get; set; }
    
        public virtual tblTim tblTim { get; set; }
    }
}
