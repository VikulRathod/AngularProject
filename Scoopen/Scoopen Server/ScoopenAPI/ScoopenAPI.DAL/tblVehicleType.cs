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
    
    public partial class tblVehicleType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblVehicleType()
        {
            this.tblVehicles = new HashSet<tblVehicle>();
        }
    
        public int VehicleTypeId { get; set; }
        public string Name { get; set; }
        public Nullable<int> Capacity { get; set; }
        public string BoxSize { get; set; }
        public string VehicleTypeImage { get; set; }
        public Nullable<int> RatePerKm { get; set; }
        public Nullable<decimal> Offer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblVehicle> tblVehicles { get; set; }
    }
}
