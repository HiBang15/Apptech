using System;
using System.Collections.Generic;

namespace NetCore1.Models
{
    public class Subject
    {
        private static int id = 0;
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }

        public Subject()
        {
            this.Exams = new HashSet<Exam>();
            id++;
            this.SubjectID = id;
        }
    }
}
