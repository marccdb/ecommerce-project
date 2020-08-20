using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eCommerceProject.Models;

namespace eCommerceProject.Data
{
    public class eCommerceProjectContext : DbContext
    {
        public eCommerceProjectContext (DbContextOptions<eCommerceProjectContext> options) : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
