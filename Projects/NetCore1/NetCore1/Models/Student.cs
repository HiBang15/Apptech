using System;
using System.Collections.Generic;

namespace NetCore1.Models
{
    public class Student
    {
        private static int id = 0;
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime StudentDOB { get; set; }
        public string StudentClass { get; set; }
        public virtual ICollection<Exam> Exams{ get; set;}
        public Student()
        {
            this.Exams = new HashSet<Exam>();
            id++;
            this.StudentID = id;
        }
    }
}
