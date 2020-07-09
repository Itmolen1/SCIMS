using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCIMSApi.Models;

namespace SCIMSApi.Interfaces
{
    public interface ICourseClassRepository
    {
        Task<List<CourseClassRoom>> All();
        Task<CourseClassRoom> Insert(CourseClassRoom courseClassRoom);
        Task<CourseClassRoom> GetById(int Id);
        Task<CourseClassRoom> Update(CourseClassRoom courseClassRoom);
        Task<CourseClassRoom> Delete(int Id);
    }
}
