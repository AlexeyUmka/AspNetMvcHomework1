using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AspNetMvcHomework1.Domain.Core.BasicModels;

namespace AspNetMvcHomework1.Infrastructure.Data.Contexts
{
    public class SheetContext : DbContext
    {
        static SheetContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SheetContext>());
        }
        public DbSet<SimpleSheet> SimpleSheets { get; set; }
    }
}
