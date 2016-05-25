using System;
using System.ComponentModel.DataAnnotations;

namespace PooStudent.WebApp.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    }

    public partial class StudentMetadata
    {
        [Required(ErrorMessage = "Please enter : Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "StudentCode")]
        [MaxLength(10)]
        public string StudentCode { get; set; }

        [Display(Name = "Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name = "Family")]
        [MaxLength(50)]
        public string Family { get; set; }

        [Display(Name = "Father")]
        [MaxLength(50)]
        public string Father { get; set; }

        [Display(Name = "SSN")]
        [MaxLength(10)]
        public string SSN { get; set; }

        [Display(Name = "BirthDate")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "RegDate")]
        public DateTime RegDate { get; set; }

    }
}
