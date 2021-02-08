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

        public async Task<EmployeeInformation> Delete(int Id)
        {
            try
            {
                var employee = await _context.EmployeeInformations.FirstOrDefaultAsync(x => x.Id == Id);
                _context.Remove(employee);
                await _context.SaveChangesAsync();

                return employee;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<EmployeeInformation> GetById(int Id)
        {
            try
            {
                var employee = await _context.EmployeeInformations.Include("SchoolInformation").Include("UserInformation").FirstOrDefaultAsync(x => x.Id == Id);
                return employee;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<EmployeeInformation> Insert(EmployeeInformation employeeInformation)
        {
            try
            {
                _context.EmployeeInformations.Add(employeeInformation);
                await _context.SaveChangesAsync();
                return employeeInformation;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<EmployeeInformation> Update(EmployeeInformation employeeInformation)
        {
            try
            {
                var employee = _context.EmployeeInformations.Attach(employeeInformation);
                employee.State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return employeeInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
