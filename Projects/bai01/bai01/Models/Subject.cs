using System;
using System.Collections.Generic;

namespace bai01.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public Subject()
        {
            this.Exams = new HashSet<Exam>();
        }
    }
}
