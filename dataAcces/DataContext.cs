using Microsoft.EntityFrameworkCore;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAcces
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<BillEntity> Bills { get; set; }
        public DbSet<BillDetailEntity> BillDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductEntity>()
                .HasIndex(t => t.Name)
                .IsUnique();
        }
    }
}
