//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Core.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class VW_UserDetails
    {
        public long UserMasterID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
        public long CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> LastLoginDateTime { get; set; }
        public string IPAddress { get; set; }
        public string MacAddress { get; set; }
        public string ModifiedByName { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string Password { get; set; }
        public Nullable<bool> ResetPassword { get; set; }
        public Nullable<System.DateTime> ResetPasswordDate { get; set; }
        public string Salt { get; set; }
        public string UserType { get; set; }
    }
}
