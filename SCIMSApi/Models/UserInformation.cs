using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Models
{
    public class UserInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Email")]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 character")]
        public string FullName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Password")]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 character")]
        public string UserPassword { get; set; }
        [Required]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; } = System.DateTime.Now;
        public bool IsActive { get; set; } = true;

        public ICollection<SchoolInformation> SchoolInformations { get; set; }
        public ICollection<ClassRoomInformation> ClassRoomInformation { get; set; }
        public ICollection<CoursesInformation> CoursesInformation { get; set; }
        public ICollection<StudentInformation> StudentInformation { get; set; }
        public ICollection<ExamInformation> ExamInformation { get; set; }
        public ICollection<EmployeeInformation> EmployeeInformation { get; set; }
        public ICollection<DepartmentInformation> DepartmentInformation { get; set; }
        public ICollection<DesignationInformation> DesignationInformation { get; set; }
    }
}
