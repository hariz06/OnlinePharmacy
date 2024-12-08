using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Configurations.Entities;
using OnlinePharmacy.Data;

namespace OnlinePharmacy.Data
{
    public class OnlinePharmacyContext(DbContextOptions<OnlinePharmacyContext> options) : IdentityDbContext<OnlinePharmacyUser>(options)
    {
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
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
        }
    }
}
