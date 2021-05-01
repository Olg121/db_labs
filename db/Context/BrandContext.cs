using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using db.DbModel;

namespace db.Context
{
    public class BrandContext : DbContext
    {
        public BrandContext()
          : base("DbConnection")
        { 
        }
        public DbSet<BrandName> Brands { get; set; }
    }
}
