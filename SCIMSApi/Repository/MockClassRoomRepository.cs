using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCIMSApi.Interfaces;
using SCIMSApi.Models;
using Microsoft.EntityFrameworkCore;

namespace SCIMSApi.Repository
{
    public class MockClassRoomRepository : IClassRoomRepository
    {
        private readonly AppDbContext _context;

        public MockClassRoomRepository(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }

        public async Task<List<ClassRoomInformation>> All()
        {
            try
            {
                return await _context.ClassRoomInformations.Include("SchoolInformation").Include("UserInformation").ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ClassRoomInformation> Delete(int Id)
        {
            try
            {
                var classRoom = await _context.ClassRoomInformations.FirstOrDefaultAsync(x => x.Id == Id);
                _context.Remove(classRoom);
                await _context.SaveChangesAsync();

                return classRoom;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ClassRoomInformation> GetById(int Id)
        {
            try
            {
                var classRoom = await _context.ClassRoomInformations.FirstOrDefaultAsync(x => x.Id == Id);
                return classRoom;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ClassRoomInformation> Insert(ClassRoomInformation classRoomInformation)
        {
            try
            {
                 _context.ClassRoomInformations.Add(classRoomInformation);
                 await _context.SaveChangesAsync();
                 return classRoomInformation;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ClassRoomInformation> Update(ClassRoomInformation classRoomInformation)
        {
            try
            {
                var classRoom = _context.ClassRoomInformations.Attach(classRoomInformation);
                classRoom.State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return classRoomInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
