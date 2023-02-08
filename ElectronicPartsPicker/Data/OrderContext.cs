using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicPartsPicker
{
    public class OrderContext : DbContext
    {
        public OrderContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ElectronicsPartsPicker;Trusted_Connection=True");
        }

        public DbSet<Order> Orders { get; set; }
    }
}
