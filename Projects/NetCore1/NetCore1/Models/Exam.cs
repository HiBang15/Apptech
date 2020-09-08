using System;
namespace NetCore1.Models
{
    public class Exam
    {
        private static int id = 0;
        public int ExamID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public int Mark { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }

        public Exam()
        {
            id++;
            this.ExamID = id;
        }
    }
}
