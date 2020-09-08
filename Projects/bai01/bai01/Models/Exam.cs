using System;
namespace bai01.Models
{
    public class Exam
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Mark { get; set; }
        public virtual Student Students { get; set; }
        public virtual Subject subjects { get; set; }
    }
}
