//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScoopenAPI.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSpecilization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSpecilization()
        {
            this.tblDrProfiles = new HashSet<tblDrProfile>();
        }
    
        public int Sp_Id { get; set; }
        public string Sp_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDrProfile> tblDrProfiles { get; set; }
    }
}