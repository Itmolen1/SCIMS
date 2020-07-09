using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SCIMSApi.Interfaces;
using SCIMSApi.Models;

namespace SCIMSApi.Repository
{
    public class MockCourseClassInformation : ICourseClassRepository
    {
        private readonly AppDbContext _context;

        public MockCourseClassInformation(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }

        public async Task<List<CourseClassRoom>> All()
        {
            try
            {
                var courseClasses = await _context.CourseClassRooms.Include("CoursesInformation").Include("ClassRoomInformation").ToListAsync();
                return courseClasses;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CourseClassRoom> Delete(int Id)
        {
            try
            {
                var courseClass = await _context.CourseClassRooms.FirstOrDefaultAsync(x => x.Id == Id);
                _context.CourseClassRooms.Remove(courseClass);
                await _context.SaveChangesAsync();
                return courseClass;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CourseClassRoom> GetById(int Id)
        {
            try
            {
                var courseClass = await _context.CourseClassRooms.FirstOrDefaultAsync(x => x.Id == Id);
                return courseClass;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CourseClassRoom> Insert(CourseClassRoom courseClassRoom)
        {
            try
            {
                await _context.CourseClassRooms.AddAsync(courseClassRoom);
                await _context.SaveChangesAsync();
                return courseClassRoom;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CourseClassRoom> Update(CourseClassRoom courseClassRoom)
        {
            try
            {
                var courseClass = _context.CourseClassRooms.Attach(courseClassRoom);
                courseClass.State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return courseClassRoom;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
