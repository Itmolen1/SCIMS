using Microsoft.EntityFrameworkCore;
using SCIMSApi.Interfaces;
using SCIMSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Repository
{
    public class MockEmployeeInformation : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public MockEmployeeInformation(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }

        public async Task<List<EmployeeInformation>> All()
        {
            try
            {
                return await _context.EmployeeInformations.Include("SchoolInformation").Include("UserInformation").ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<EmployeeInformation> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeInformation> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeInformation> Insert(EmployeeInformation employeeInformation)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeInformation> Update(EmployeeInformation employeeInformation)
        {
            throw new NotImplementedException();
        }
    }
}
