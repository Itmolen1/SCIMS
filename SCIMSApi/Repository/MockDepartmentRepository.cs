using Microsoft.EntityFrameworkCore;
using SCIMSApi.Interfaces;
using SCIMSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Repository
{
    public class MockDepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;

        public MockDepartmentRepository(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }

        public async Task<List<DepartmentInformation>> All()
        {
            try
            {
                return await _context.DepartmentInformations.Include("SchoolInformation").Include("UserInformation").ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DepartmentInformation> Delete(int Id)
        {
            try
            {
                var department = await _context.DepartmentInformations.FirstOrDefaultAsync(x => x.Id == Id);
                _context.Remove(department);
                await _context.SaveChangesAsync();

                return department;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DepartmentInformation> GetById(int Id)
        {
            try
            {
                var department = await _context.DepartmentInformations.FirstOrDefaultAsync(x => x.Id == Id);
                return department;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DepartmentInformation> Insert(DepartmentInformation departmentInformation)
        {
            try
            {
                _context.DepartmentInformations.Add(departmentInformation);
                await _context.SaveChangesAsync();
                return departmentInformation;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DepartmentInformation> Update(DepartmentInformation departmentInformation)
        {
            try
            {
                var classRoom = _context.DepartmentInformations.Attach(departmentInformation);
                classRoom.State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return departmentInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
