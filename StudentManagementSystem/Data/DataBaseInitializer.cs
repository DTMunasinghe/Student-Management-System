using StudentManagementSystem.Models;
using System;
using System.Linq;

namespace StudentManagementSystem.Data
{
    public static class DataBaseInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            /*
            The code checks if there are any students in the database, and 
            if not, it assumes the database is new and needs to be seeded with test data.
            */
            if (context.Students.Any())
            {
                return;  //DataBase has been seed.
            }

            var students = new Student[]
            {
                new Student{FirstName = "Tharana", LastName = "Sanjuka",DateOfBirth = DateTime.Parse("1998-08-01"), Address = "No 102, Hakmana Road, Matara", Email = "thara123@gmail.com"},
                new Student{FirstName = "Buddila", LastName = "Manahara",DateOfBirth = DateTime.Parse("1990-02-25"), Address = "N0. 201, Galle Road, Colombo", Email = "buddhidig@gmail.com"},
                new Student{FirstName = "Anushan", LastName = "Madushanka",DateOfBirth = DateTime.Parse("1988-07-16"), Address = "Dimuthu, Kirinda, Puhulwella", Email = "anushamadu@gmail.com"},
                new Student{FirstName = "Dilshan", LastName = "Pamuditha",DateOfBirth = DateTime.Parse("1992-12-26"), Address = "Subodhi, Kirinda, Puhulwella", Email = "dilshandig@gmail.com"},
                new Student{FirstName = "Gimshan", LastName = "Achintha",DateOfBirth = DateTime.Parse("1996-05-15"), Address = "No 50/2, Ella Road, Badulla", Email = "gimshan99@gmail.com"}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID = 101, CourseName = "Software Engineering", Description = "This is a four year full time course"},
                new Course{CourseID = 201, CourseName = "Management", Description = "This is a four year full time course"},
                new Course{CourseID = 301, CourseName = "Diploma in English", Description = "This is a six months full time course"},
                new Course{CourseID = 401, CourseName = "Teaching", Description = "This is a three year full time course"},
                new Course{CourseID = 501, CourseName = "Nursing", Description = "This is a three year full time course"}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{CourseID = 501, StudentID = 1, EnrolementDate = DateTime.Parse("2017-11-26")},
                new Enrollment{CourseID = 401, StudentID = 2, EnrolementDate = DateTime.Parse("2017-11-27")},
                new Enrollment{CourseID = 301, StudentID = 3, EnrolementDate = DateTime.Parse("2017-11-26")},
                new Enrollment{CourseID = 201, StudentID = 4, EnrolementDate = DateTime.Parse("2017-11-27")},
                new Enrollment{CourseID = 101, StudentID = 5, EnrolementDate = DateTime.Parse("2017-11-28")}
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
