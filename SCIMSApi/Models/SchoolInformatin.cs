using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Models
{
    public class SchoolInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(150, ErrorMessage = "Maximum allowed 150 character")]
        public string Name { get; set; }
        public string RegistrationNo { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        [MaxLength(20)]
        public string Mobile { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        public string Logo { get; set; }
        public int CreatedBy { get; set; } = 0;
        public DateTime CreatedDate { get; set; } = System.DateTime.Now;
        public bool IsActive { get; set; } = true;

        public UserInformation UserInformation { get; set; }
        public ICollection<ClassRoomInformation> ClassRoomInformation { get; set; }
        public ICollection<CoursesInformation> CoursesInformation { get; set; }
        public ICollection<StudentInformation> StudentInformation { get; set; }
        public ICollection<ExamInformation> ExamInformation { get; set; }
        public ICollection<EmployeeInformation> EmployeeInformation { get; set; }
        public ICollection<DepartmentInformation> DepartmentInformation { get; set; }
    }
}
