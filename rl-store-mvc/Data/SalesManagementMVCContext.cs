using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesManagementMVC.Models;

namespace SalesManagementMVC.Data
{
    public class SalesManagementMVCContext : DbContext
    {
        public SalesManagementMVCContext (DbContextOptions<SalesManagementMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }

    }
}
