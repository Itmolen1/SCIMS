using SCIMSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Interfaces
{
    public interface IBloodGroupRepository
    {
        Task<List<BloodGroupInformation>> All();
        Task<BloodGroupInformation> Insert(BloodGroupInformation bloodGroupInformation);
        Task<BloodGroupInformation> GetById(int Id);
        Task<BloodGroupInformation> Update(BloodGroupInformation bloodGroupInformation);
        Task<BloodGroupInformation> Delete(int Id);
    }
}
