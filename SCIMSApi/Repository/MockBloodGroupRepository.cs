using Microsoft.EntityFrameworkCore;
using SCIMSApi.Interfaces;
using SCIMSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Repository
{
    public class MockBloodGroupRepository : IBloodGroupRepository
    {

        private readonly AppDbContext _context;
        public MockBloodGroupRepository(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }

        public async Task<List<BloodGroupInformation>> All()
        {
            try
            {
                return await _context.BloodGroupInformations.Include("UserInformation").ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<BloodGroupInformation> Delete(int Id)
        {
            try
            {
                var bloodGroup = await _context.BloodGroupInformations.FirstOrDefaultAsync(x => x.Id == Id);
                _context.Remove(bloodGroup);
                await _context.SaveChangesAsync();

                return bloodGroup;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<BloodGroupInformation> GetById(int Id)
        {
            try
            {
                var bloodGroup = await _context.BloodGroupInformations.FirstOrDefaultAsync(x => x.Id == Id);
                return bloodGroup;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<BloodGroupInformation> Insert(BloodGroupInformation bloodGroupInformation)
        {
            try
            {
                _context.BloodGroupInformations.Add(bloodGroupInformation);
                await _context.SaveChangesAsync();
                return bloodGroupInformation;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<BloodGroupInformation> Update(BloodGroupInformation bloodGroupInformation)
        {
            try
            {
                var bloodGroup = _context.BloodGroupInformations.Attach(bloodGroupInformation);
                bloodGroup.State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return bloodGroupInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
