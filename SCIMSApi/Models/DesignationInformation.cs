using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Models
{
    public class DesignationInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "allwed 100 character")]
        public string Name { get; set; }
        public int SchoolId { get; set; }
        [MaxLength(600, ErrorMessage = "allowed 600 character")]
        public string Description { get; set; }
        public int CreatedBy { get; set; } = 0;
        public DateTime CreatedDate { get; set; } = System.DateTime.Now;
        public bool IsActive { get; set; } = true;

        [ForeignKey("CreatedBy")]
        public SchoolInformation SchoolInformation { get; set; }
        [ForeignKey("SchoolId")]
        public UserInformation UserInformation { get; set; }
    }
}
