using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Models
{
    public class CourseClassRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ClassRoomId { get; set; }
        public int CourseId { get; set; }
        public bool IsActive { get; set; }
        public CoursesInformation CoursesInformation { get; set; }
        public ClassRoomInformation ClassRoomInformation { get; set; }
    }
}
