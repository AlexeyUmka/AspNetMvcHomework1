using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AspNetMvcHomework1.Models;

namespace AspNetMvcHomework1.Models
{
    public class ReviewContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
    }
}