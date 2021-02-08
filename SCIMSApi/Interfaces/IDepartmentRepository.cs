using SCIMSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<List<DepartmentInformation>> All();
        Task<DepartmentInformation> Insert(DepartmentInformation departmentInformation);
        Task<DepartmentInformation> GetById(int Id);
        Task<DepartmentInformation> Update(DepartmentInformation departmentInformation);
        Task<DepartmentInformation> Delete(int Id);
    }
}
