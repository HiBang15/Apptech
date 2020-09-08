using System;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> data) : base(data)
        {
        }
        public DbSet<Person> Persons { get; set; }
    }
}
