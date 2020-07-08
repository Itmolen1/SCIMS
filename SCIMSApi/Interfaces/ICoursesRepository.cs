using SCIMSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Interfaces
{
    public interface ICoursesRepository
    {
        Task<List<CoursesInformation>> All();
        Task<CoursesInformation> Insert(CoursesInformation coursesInformation);
        Task<CoursesInformation> GetById(int Id);
        Task<CoursesInformation> Update(CoursesInformation coursesInformation);
        Task<CoursesInformation> Delete(int Id);
    }
}
