using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Configurations.Entities;
using OnlinePharmacy.Domain;

namespace OnlinePharmacy.Data
{
    public class OnlinePharmacyContext : DbContext
    {
        public OnlinePharmacyContext (DbContextOptions<OnlinePharmacyContext> options)
            : base(options)
        {
        }

        public DbSet<OnlinePharmacy.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<OnlinePharmacy.Domain.Order> Order { get; set; } = default!;
        public DbSet<OnlinePharmacy.Domain.Staff> Staff { get; set; } = default!;
        public DbSet<OnlinePharmacy.Domain.Shop> Shop { get; set; } = default!;
        public DbSet<OnlinePharmacy.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<OnlinePharmacy.Domain.Product> Product { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProductSeed());
            builder.ApplyConfiguration(new ShopSeed());
        }
    }
}
