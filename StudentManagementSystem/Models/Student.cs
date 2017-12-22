using System;
using System.Collections.Generic;

namespace StudentManagementSystem.Models
{
    public class Student
    {

        public int StudentID { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public String Address { get; set; }

        public String Email { get; set; }

        //just add this and update database
        //public bool Gender { get; set; }

        public List<Enrollment> Enrolements { get; set; }
    }
}
