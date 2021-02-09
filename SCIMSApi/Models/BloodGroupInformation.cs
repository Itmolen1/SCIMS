using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Models
{
    public class BloodGroupInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string BloodGroup { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public int SchoolId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        
        [ForeignKey("CreatedBy")]
        public UserInformation UserInformation { get; set; }
        [ForeignKey("SchoolId")]
        public SchoolInformation SchoolInformation { get; set; }
        public ICollection<EmployeeInformation> EmployeeInformations { get; set; }
    }
}
