using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Models
{
    public class ExamInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide exame Name")]
        [MaxLength(100, ErrorMessage = "Allwed lenth is 100 character only")]
        public string ExamName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int SchoolId { get; set; }
        public bool IsActive { get; set; } = true;

        [ForeignKey("SchoolId")]
        public SchoolInformation SchoolInformation { get; set; }
        [ForeignKey("CreatedBy")]
        public UserInformation UserInformation { get; set; }
    }
}
