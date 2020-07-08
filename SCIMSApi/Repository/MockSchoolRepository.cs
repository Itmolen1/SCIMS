using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SCIMSApi.Interfaces;
using SCIMSApi.Models;

namespace SCIMSApi.Repository
{
    public class MockSchoolRepository : ISchoolRepository
    {
        private readonly AppDbContext _context;

        public MockSchoolRepository(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }

        public async Task<List<SchoolInformation>> All()
        {
            try
            {
                var schools = await _context.SchoolInformations.Include("UserInformation").ToListAsync();
                return schools;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<SchoolInformation> Insert(SchoolInformation schoolInformation)
        {
            try
            {
                await _context.AddAsync(schoolInformation);
                await _context.SaveChangesAsync();
                return schoolInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<SchoolInformation> GetById(int Id)
        {
            try
            {
                var school = await _context.SchoolInformations.Include("UserInformation").FirstOrDefaultAsync(x => x.Id == Id);
                return school;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<SchoolInformation> Update(SchoolInformation schoolInformation)
        {
            try
            {
                var school =  _context.SchoolInformations.Attach(schoolInformation);
                school.State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return schoolInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<SchoolInformation> Delete(int Id)
        {
            try
            {
                var school = await _context.SchoolInformations.FirstOrDefaultAsync(x => x.Id == Id);
                _context.Remove(school);
                await _context.SaveChangesAsync();

                return school;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
