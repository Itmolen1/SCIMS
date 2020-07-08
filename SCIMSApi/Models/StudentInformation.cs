using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Models
{
    public class StudentInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide student name")]
        [MaxLength(100, ErrorMessage = "Allwed only 100 character")]
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string EmergencyContact { get; set; }
        [MaxLength(500, ErrorMessage = "Allowed only 500 character")]
        public string Descriptions { get; set; }
        public int SchoolId { get; set; }
        public int CreatedBy { get; set; }
        [ForeignKey("SchoolId")]
        public SchoolInformation SchoolInformation { get; set; }
        [ForeignKey("CreatedBy")]
        public UserInformation UserInformation { get; set; }

    }
}
