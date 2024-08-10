using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomersCRUD.Models;

namespace CustomersCRUD.Data
{
    public class CustomersCRUDContext : DbContext
    {
        public CustomersCRUDContext (DbContextOptions<CustomersCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<CustomersCRUD.Models.Customer> Customer { get; set; } = default!;
    }
}
