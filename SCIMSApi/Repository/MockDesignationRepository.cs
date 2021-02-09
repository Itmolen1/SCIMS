using Microsoft.EntityFrameworkCore;
using SCIMSApi.Interfaces;
using SCIMSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Repository
{
    public class MockDesignationRepository : IDesignationRepository
    {
        private readonly AppDbContext _context;

        public MockDesignationRepository(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }

        public async Task<List<DesignationInformation>> All()
        {
            try
            {
                return await _context.DesignationInformations.Include("SchoolInformation").Include("UserInformation").ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DesignationInformation> Delete(int Id)
        {
            try
            {
                var designation = await _context.DesignationInformations.FirstOrDefaultAsync(x => x.Id == Id);
                _context.Remove(designation);
                await _context.SaveChangesAsync();

                return designation;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DesignationInformation> GetById(int Id)
        {
            try
            {
                var designation = await _context.DesignationInformations.FirstOrDefaultAsync(x => x.Id == Id);
                return designation;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DesignationInformation> Insert(DesignationInformation designationInformation)
        {
            try
            {
                _context.DesignationInformations.Add(designationInformation);
                await _context.SaveChangesAsync();
                return designationInformation;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DesignationInformation> Update(DesignationInformation designationInformation)
        {
            try
            { 
                var designation = _context.DesignationInformations.Attach(designationInformation);
                designation.State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return designationInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
