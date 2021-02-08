using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SCIMSApi.Models;

namespace SCIMSApi.ModelBuilders
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().HasData(
                new Gender { Id = 1, GenderName = "Male" },
                new Gender { Id = 2, GenderName = "Female" }
            );

            modelBuilder.Entity<UserInformation>()
                .HasOne(p => p.Gender)
                .WithMany(q => q.UserInformations)
                .HasForeignKey(r => r.GenderId);

            modelBuilder.Entity<UserInformation>().HasData(
                new UserInformation
                {
                    Id = 1,
                    FullName = "Admin",
                    UserName = "admin@gmail.com",
                    UserPassword = "1234",
                    GenderId = 1,
                    IsActive = true,
                    CreatedDate = System.DateTime.Now
                }
                );

            modelBuilder.Entity<SchoolInformation>()
                .HasOne(P => P.UserInformation)
                .WithMany(q => q.SchoolInformations)
                .HasForeignKey(x => x.CreatedBy);


            modelBuilder.Entity<SchoolInformation>().HasData(
                new SchoolInformation
                {
                    Id = 1,
                    Name = "Test School One",
                    Address = "Abu Dhabi, UAE",
                    Logo = "this.png",
                    Mobile = "91 45454655",
                    Phone = "0302 45454555",
                    RegistrationNo = "011121110",
                    CreatedDate = System.DateTime.Now,
                    CreatedBy = 1,
                    IsActive = true,
                }
                );

            modelBuilder.Entity<ClassRoomInformation>().HasData(
                new ClassRoomInformation
                {
                    Id = 1,
                    Name = "Class 1",
                    Description = "Test Class Room",
                    SchoolId = 1,
                    CreatedDate = System.DateTime.Now,
                    IsActive = true,
                    CreatedBy = 1
                });

            modelBuilder.Entity<ClassRoomInformation>()
               .HasOne(P => P.UserInformation)
               .WithMany(q => q.ClassRoomInformation)
               .HasForeignKey(x => x.CreatedBy)
               .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<ClassRoomInformation>()
               .HasOne(P => P.SchoolInformation)
               .WithMany(q => q.ClassRoomInformation)
               .HasForeignKey(x => x.SchoolId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CoursesInformation>().HasData(
                    new CoursesInformation
                    {
                        Id = 1,
                        Name = "Course One",
                        Description = "Test Course",
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        SchoolId = 1,
                        IsActive = true,
                        TotalMarks = 100
                    }
                );

            modelBuilder.Entity<CoursesInformation>()
                .HasOne(p => p.SchoolInformation)
                .WithMany(q => q.CoursesInformation)
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CoursesInformation>()
                .HasOne(p => p.UserInformation)
                .WithMany(q => q.CoursesInformation)
                .HasForeignKey(x => x.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StudentInformation>().HasData(
                new StudentInformation
                {
                    Id = 1,
                    Name = "Test Student Name",
                    Descriptions = "this is first test student from seeds",
                    ContactNumber = "1313213",
                    EmergencyContact = "13211313",
                    CreatedBy = 1,
                    SchoolId = 1
                }
                );

            modelBuilder.Entity<StudentInformation>()
                .HasOne(p => p.SchoolInformation)
                .WithMany(q => q.StudentInformation)
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StudentInformation>()
              .HasOne(p => p.UserInformation)
              .WithMany(q => q.StudentInformation)
              .HasForeignKey(x => x.CreatedBy)
              .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<CourseClassRoom>()
                 .HasKey(x => new { x.CourseId, x.ClassRoomId });

            modelBuilder.Entity<CourseClassRoom>()
                .HasOne(x => x.ClassRoomInformation)
                .WithMany(y => y.CourseClassRooms)
                .HasForeignKey(x => x.ClassRoomId);

            modelBuilder.Entity<CourseClassRoom>()
                .HasOne(x => x.CoursesInformation)
                .WithMany(y => y.CourseClassRooms)
                .HasForeignKey(y => y.CourseId);

            modelBuilder.Entity<CourseClassRoom>()
                .HasData(
                    new CourseClassRoom
                    {
                        Id = 1,
                        ClassRoomId = 1,
                        CourseId = 1,
                        IsActive = true
                    }
                );

            modelBuilder.Entity<ExamInformation>().HasData(
                new ExamInformation
                    {
                        Id = 1,
                        ExamName = "First Term",
                        SchoolId = 1,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                    }
                );

            modelBuilder.Entity<ExamInformation>()
                .HasOne(q => q.SchoolInformation)
                .WithMany(p => p.ExamInformation)
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ExamInformation>()
                .HasOne(q => q.UserInformation)
                .WithMany(p => p.ExamInformation)
                .HasForeignKey(x => x.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DepartmentInformation>()
                .HasOne(q => q.UserInformation)
                .WithMany(p => p.DepartmentInformation)
                .HasForeignKey(x => x.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DepartmentInformation>()
                .HasOne(q => q.SchoolInformation)
                .WithMany(p => p.DepartmentInformation)
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DepartmentInformation>()
                .HasData(
                new DepartmentInformation
                {
                    Id=1,
                    Name = "Urdu",
                    CreatedBy =1,
                    CreatedDate = System.DateTime.Now,
                    Description = "New test department added",
                    IsActive = true,
                    SchoolId = 1
                });

            modelBuilder.Entity<DesignationInformation>()
                .HasOne(q => q.SchoolInformation)
                .WithMany(p => p.DesignationInformation)
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DesignationInformation>()
                .HasOne(q => q.UserInformation)
                .WithMany(p => p.DesignationInformation)
                .HasForeignKey(x => x.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DesignationInformation>()
                .HasData(
                        new DesignationInformation
                        {
                            Id = 1,
                            Name = "Test Desugnation",
                            CreatedBy = 1,
                            CreatedDate = System.DateTime.Now,
                            Description = "New test Designation is created",
                            IsActive = true,
                            SchoolId = 1
                        });



            modelBuilder.Entity<EmployeeInformation>()
                .HasOne(q => q.UserInformation)
                .WithMany(p => p.EmployeeInformation)
                .HasForeignKey(x => x.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeInformation>()
                .HasOne(q => q.SchoolInformation)
                .WithMany(p => p.EmployeeInformation)
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeInformation>()
                .HasData(
                new EmployeeInformation {
                    Id = 1,
                    Name = "Test Employee",
                    DateofBirth = System.DateTime.Now,
                    CreatedBy = 1,
                    CreatedDate = System.DateTime.Now,
                    Description = "New Test Employee Added",
                    IsActive = true,
                    SchoolId = 1                    
                }
                );

        }
    }
}
