using SCIMSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Interfaces
{
    public interface ISchoolRepository
    {
        Task<List<SchoolInformation>> All();
        Task<SchoolInformation> Insert(SchoolInformation schoolInformation);
        Task<SchoolInformation> GetById(int Id);
        Task<SchoolInformation> Update(SchoolInformation schoolInformation);
        Task<SchoolInformation> Delete(int Id);
    }
}
