using EvoWebsite.Data.Configurations;
using EvoWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvoWebsite.Data
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarConfiguration());

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Importe> Importes { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
