using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebService.Models;

namespace SalesWebService.Data
{
    public class SalesWebServiceContext : DbContext
    {
        public SalesWebServiceContext (DbContextOptions<SalesWebServiceContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
