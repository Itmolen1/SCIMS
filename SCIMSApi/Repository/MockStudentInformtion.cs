using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCIMSApi.Interfaces;
using SCIMSApi.Models;
using Microsoft.EntityFrameworkCore;

namespace SCIMSApi.Repository
{
    public class MockStudentInformtion : IStudentRepository
    {
        private readonly AppDbContext _context;

        public MockStudentInformtion(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }

        public async Task<List<StudentInformation>> All()
        {
            try
            {
                var students = await _context.StudentInformations.ToListAsync();
                return students;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<StudentInformation> Delete(int Id)
        {
            try
            {
                var student = await _context.StudentInformations.FirstOrDefaultAsync(x => x.Id == Id);
                _context.StudentInformations.Remove(student);
                 await _context.SaveChangesAsync();

                return student;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<StudentInformation> GetById(int Id)
        {
            try
            {
                var student = await _context.StudentInformations.FirstOrDefaultAsync(x => x.Id == Id);
                return student;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<StudentInformation> Insert(StudentInformation studentInformation)
        {
            try
            {
                var student = await _context.StudentInformations.AddAsync(studentInformation);
                await _context.SaveChangesAsync();
                return studentInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<StudentInformation> Update(StudentInformation studentInformation)
        {
            try
            {
                var student =  _context.StudentInformations.Attach(studentInformation);
                student.State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return studentInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
