using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPOC.Models
{
    public class CustomerContext:DbContext
    {
        // Pass the connstrng and provider
        public CustomerContext(DbContextOptions<CustomerContext> options) :base(options)
        {

        }

        public DbSet<Customer> customers { get; set; }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
