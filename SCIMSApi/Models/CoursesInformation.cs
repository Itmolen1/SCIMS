﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Models
{
    public class CoursesInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide course name")]
        [MaxLength(100,ErrorMessage = "Allwed only 500 character")]
        public string Name { get; set; }
        [MaxLength(500,ErrorMessage = "Allwed only 500 character")]
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = System.DateTime.Now;
        [Required(ErrorMessage = "Please provide total marks of the course")]
        public int TotalMarks { get; set; } = 0;
        public int SchoolId { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("SchoolId")]
        public SchoolInformation SchoolInformation { get; set; }
        [ForeignKey("CreatedBy")]
        public UserInformation UserInformation { get; set; }
        public ICollection<CourseClassRoom> CourseClassRooms { get; set; }
    }
}
