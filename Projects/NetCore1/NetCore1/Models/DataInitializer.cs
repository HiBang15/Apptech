using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data.Entity;

namespace NetCore1.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {

        protected override void Seed(DataContext context)
        {
            base.Seed(context);

        }
    }
}
