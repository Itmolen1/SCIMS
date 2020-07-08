using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCIMSApi.Models;

namespace SCIMSApi.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<StudentInformation>> All();
        Task<StudentInformation> Insert(StudentInformation studentInformation);
        Task<StudentInformation> GetById(int Id);
        Task<StudentInformation> Update(StudentInformation studentInformation);
        Task<StudentInformation> Delete(int Id);
    }
}
