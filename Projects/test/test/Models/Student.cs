using System;
using System.Collections.Generic;

namespace test.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime StudentDOB { get; set; }
        public string StudentClass { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }

        public Student()
        {
            this.Exams = new HashSet<Exam>();
        }
    }
}
