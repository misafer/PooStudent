//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PooStudent.WebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int Id { get; set; }
        public string StudentCode { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Father { get; set; }
        public string SSN { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
    }
}
