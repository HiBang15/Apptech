using System;
using System.Data.Entity;

namespace NetCore1.Models
{
    public class DataContext: DbContext
    {
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }

        public DataContext()
        {
            Database.SetInitializer<DataContext>(new DataInitializer());
            Subjects.Add(new Subject() { SubjectName = "Java" });
            Subjects.Add(new Subject() { SubjectName = "C#" });
            Subjects.Add(new Subject() { SubjectName = "php" });
            Students.Add(new Student() { StudentName = "Hoang A", StudentDOB = new DateTime(2000, 12, 1) });
            Students.Add(new Student() { StudentName = "Hoang B", StudentDOB = new DateTime(2003, 12, 1) });
            Students.Add(new Student() { StudentName = "Hoang C", StudentDOB = new DateTime(2001, 12, 1) });
            Exams.Add(new Exam() { StudentID = 1, SubjectID = 3, Mark = 5 });
            Exams.Add(new Exam() { StudentID = 1, SubjectID = 2, Mark = 8 });
            Exams.Add(new Exam() { StudentID = 2, SubjectID = 1, Mark = 6 });
            this.SaveChanges();
        }
    }
}
