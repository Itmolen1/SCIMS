using SCIMSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Interfaces
{
    public interface IDesignationRepository
    {
        Task<List<DesignationInformation>> All();
        Task<DesignationInformation> Insert(DesignationInformation designationInformation);
        Task<DesignationInformation> GetById(int Id);
        Task<DesignationInformation> Update(DesignationInformation designationInformation);
        Task<DesignationInformation> Delete(int Id);
    }
}
