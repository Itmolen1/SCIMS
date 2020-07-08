using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SCIMSApi.Interfaces;
using SCIMSApi.Models;

namespace SCIMSApi.Repository
{
    public class MockUserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public MockUserRepository(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }

        public async Task<List<UserInformation>> All()
        {
            try
            {
               var users = await _context.UserInformations.Include("Gender").ToListAsync();
               return users;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserInformation> Insert(UserInformation userInformation)
        {
            try
            {
               await _context.AddAsync(userInformation);
               await _context.SaveChangesAsync();
               return userInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserInformation> Delete(int Id)
        {
            try
            {
                var user = _context.UserInformations.Find(Id);
                 _context.UserInformations.Remove(user);
                 await _context.SaveChangesAsync();
                 return user;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserInformation> GetById(int Id)
        {
            try
            {
                return await _context.UserInformations.Include("Gender").FirstOrDefaultAsync(x=>x.Id == Id);
            }   
            catch (Exception)
            {
                throw;
            }
        }
        
        public async Task<UserInformation> Update(UserInformation userInformation)
        {
            try
            {
                var user = _context.UserInformations.Attach(userInformation);
                 user.State =  EntityState.Modified;
                await _context.SaveChangesAsync();
                return userInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
