using System;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace bai01.Models
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public DataContext()
        {
            Database.SetInitializer<DataContext>(new DataInitializer<DataContext>());
        }
    }
}
