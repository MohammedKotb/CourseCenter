//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseCenterMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemUser
    {
        public SystemUser()
        {
            this.SystemUser1 = new HashSet<SystemUser>();
        }
    
        public long ID { get; set; }
        public string Name { get; set; }
        public string ImgURL { get; set; }
        public string Role { get; set; }
        public Nullable<long> AddedBy { get; set; }
        public bool ISDeleted { get; set; }
        public bool ISActive { get; set; }
    
        public virtual ICollection<SystemUser> SystemUser1 { get; set; }
        public virtual SystemUser SystemUser2 { get; set; }
    }
}
