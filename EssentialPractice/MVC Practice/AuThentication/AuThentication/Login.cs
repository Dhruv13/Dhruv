//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuThentication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login
    {
        public int LoginId { get; set; }
        public string UserMail { get; set; }
        public string UserPass { get; set; }
        public Nullable<System.DateTime> DateLastLogin { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> RoleId { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
