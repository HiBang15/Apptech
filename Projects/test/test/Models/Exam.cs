using System;
namespace test.Models
{
    public class Exam
    {
        public int ExamID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public float Mark { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
