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
    
    public partial class tblDrProfile
    {
        public int Profile_Id { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Address1 { get; set; }
        public Nullable<int> Spl_Id { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual tblSpecilization tblSpecilization { get; set; }
        public virtual tblUserInfo tblUserInfo { get; set; }
    }
}
