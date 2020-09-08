using System;
using Microsoft.EntityFrameworkCore;

namespace bai01.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>;
    {
        public DataInitializer()
        {
        }
    }
}
