using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Models
{
    public class EmployeeInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide name")]
        [MaxLength(100, ErrorMessage = "Allwed only 500 character")]
        public string Name { get; set; }
        [MaxLength(500, ErrorMessage = "Allwed only 500 character")]
        public string Description { get; set; }
        public int GenderId { get; set; } = 1;
        [MaxLength(500, ErrorMessage = "Allwed only 500 character")]
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string EmergencyContactNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }       
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = System.DateTime.Now;
        public DateTime DateofBirth { get; set; } = System.DateTime.Now;
        public DateTime HireDate { get; set; } = System.DateTime.Now;
        public string ImageUrl { get; set; }
        public int DepartmentId { get; set; }
        public int SchoolId { get; set; }
        //public int BloodGroupId { get; set; }
        public bool IsActive { get; set; }
        public int Age { get; set; }
        
        [ForeignKey("SchoolId")]
        public SchoolInformation SchoolInformation { get; set; }
        [ForeignKey("CreatedBy")]
        public UserInformation UserInformation { get; set; }
        [ForeignKey("GenderId")]
        public Gender Gender { get; set; }
        //[ForeignKey("BloodGroupId")]
        //public BloodGroupInformation BloodGroupInformation { get; set;}
        [ForeignKey("DepartmentId")]
        public DepartmentInformation DepartmentInformation { get; set; }
    }
}
