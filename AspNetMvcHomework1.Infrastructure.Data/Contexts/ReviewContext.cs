using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AspNetMvcHomework1.Domain.Core.BasicModels;

namespace AspNetMvcHomework1.Infrastructure.Data.Contexts
{
    public class ReviewContext : DbContext
    {
        static ReviewContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ReviewContext>());
        }
        public DbSet<SimpleReview> SimpleReviews { get; set; }
    }
}
