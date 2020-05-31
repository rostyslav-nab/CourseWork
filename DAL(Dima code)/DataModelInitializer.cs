using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class DataModelInitializer : DropCreateDatabaseIfModelChanges<TimeTable>
    {
        protected override void Seed(TimeTable context)
        {
            context.SaveChanges();
        }

    }
}
