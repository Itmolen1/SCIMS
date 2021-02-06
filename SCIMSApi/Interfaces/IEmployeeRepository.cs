using SCIMSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeInformation>> All();
        Task<EmployeeInformation> Insert(EmployeeInformation employeeInformation);
        Task<EmployeeInformation> GetById(int Id);
        Task<EmployeeInformation> Update(EmployeeInformation employeeInformation);
        Task<EmployeeInformation> Delete(int Id);
    }
}
