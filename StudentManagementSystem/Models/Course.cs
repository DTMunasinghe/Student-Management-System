using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        public String CourseName { get; set; }

        public String Description { get; set; }

        public List<Enrollment> Enrolements { get; set; }
    }
}
