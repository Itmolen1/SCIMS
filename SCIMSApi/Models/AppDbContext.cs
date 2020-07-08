using Microsoft.EntityFrameworkCore;
using SCIMSApi.ModelBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCIMSApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UserInformation> UserInformations { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<SchoolInformation> SchoolInformations { get; set; }
        public DbSet<ClassRoomInformation> ClassRoomInformations { get; set; }
        public DbSet<CoursesInformation> CoursesInformations { get; set; }
        public DbSet<StudentInformation> StudentInformations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
