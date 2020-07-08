using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCIMSApi.Interfaces;
using SCIMSApi.Models;
using Microsoft.EntityFrameworkCore;

namespace SCIMSApi.Repository
{
    public class MockCoursesRepository : ICoursesRepository
    {
        private readonly AppDbContext _context;

        public MockCoursesRepository(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }

        public async Task<List<CoursesInformation>> All()
        {
            try
            {
                var Courses = await _context.CoursesInformations.Include("SchoolInformation").Include("UserInformation").ToListAsync();
                return Courses;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CoursesInformation> Delete(int Id)
        {
            try
            {
                var course = await _context.CoursesInformations.FirstOrDefaultAsync(x => x.Id == Id);
                _context.Remove(course);
                await _context.SaveChangesAsync();
                return course;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CoursesInformation> GetById(int Id)
        {
            try
            {
                var course = await _context.CoursesInformations.FirstOrDefaultAsync(x => x.Id == Id);
                return course;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CoursesInformation> Insert(CoursesInformation coursesInformation)
        {
            try
            {
                var course = await _context.AddAsync(coursesInformation);
                await _context.SaveChangesAsync();
                return coursesInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CoursesInformation> Update(CoursesInformation coursesInformation)
        {
            var course = _context.Attach(coursesInformation);
            course.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return coursesInformation;
        }
    }
}
