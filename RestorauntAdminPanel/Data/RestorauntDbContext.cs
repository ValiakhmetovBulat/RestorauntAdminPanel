using Microsoft.EntityFrameworkCore;
using Restoraunt.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorauntAdminPanel.Data
{
    internal class RestorauntDbContext : DbContext
    {
        public DbSet<MenuPosition> MenuPositions { get; set; }
        public DbSet<PositionType> PositionTypes { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public RestorauntDbContext(DbContextOptions<RestorauntDbContext> options) : base(options) { }
        public RestorauntDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Database=RestorauntDb;Port=5432;User Id=postgres;Password=youngcursedkid");
        }    
    }
}
