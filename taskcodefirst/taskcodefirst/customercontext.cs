using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace taskcodefirst
{
    class customercontext:DbContext
    {
        public customercontext() : base("customercontext") { }
        public DbSet<customer> Customers { get; set; }
        public DbSet<product> Products { get; set; }
        public DbSet<purchase> Purchases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

    }

}

