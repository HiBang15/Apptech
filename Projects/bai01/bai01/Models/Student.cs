using System;
using System.Collections.Generic;

namespace bai01.Models
{
    public class Student
    {
        public int StudentId { get; set; }
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
