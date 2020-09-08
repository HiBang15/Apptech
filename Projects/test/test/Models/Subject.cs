using System;
using System.Collections.Generic;

namespace test.Models
{
    public class Subject
    {
        
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public Subject()
        {
            this.Exams = new HashSet<Exam>();
        }
    }
}
