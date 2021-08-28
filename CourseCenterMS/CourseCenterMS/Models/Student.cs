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
    
    public partial class Student
    {
        public Student()
        {
            this.Attendances = new HashSet<Attendance>();
            this.Transactions = new HashSet<Transaction>();
        }
    
        public long ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string FatherPhone { get; set; }
        public string MotherPhone { get; set; }
        public bool IsFatherPrimary { get; set; }
        public string FatherJob { get; set; }
        public string School { get; set; }
        public string Classroom { get; set; }
        public string ImgURL { get; set; }
        public string Address { get; set; }
        public string Chronicdisease { get; set; }
        public string QR { get; set; }
        public Nullable<long> GroupID { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public string Gender { get; set; }
        public Nullable<long> DepartmentID { get; set; }
        public string GroupName { get; set; }
    
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual Department Department1 { get; set; }
        public virtual Group Group { get; set; }
    }
}
