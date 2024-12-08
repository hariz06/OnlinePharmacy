using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePharmacy.Domain;

namespace OnlinePharmacy.Configurations.Entities
{
    public class ShopSeed : IEntityTypeConfiguration<Shop>

    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.HasData(
                new Shop
                {
                   Id = 1,
                   Name = "Unity",
                   Address = "Pasir Ris West Plaza",
                   Contact = "12345678",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
                },
                new Shop
                {
                   Id = 2,
                   Name = "Watson",
                   Contact = "11223344",
                   Address = "WaterWay Point",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
                }
            );
        }
    }
}
