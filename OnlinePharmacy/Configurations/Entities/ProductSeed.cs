using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePharmacy.Domain;
using System.Drawing;

namespace OnlinePharmacy.Configurations.Entities
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                    new Product
                    {
                        Id = 1,
                        Prod_Name = "Cough Syrup",
                        Prod_Type = "Medicine",
                        Cost = "15.00",
                        Quantity = 15,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Product
                    {
                        Id = 2,
                        Prod_Name = "Face Mask",
                        Prod_Type = "Cosmetic",
                        Cost = "10.00",
                        Quantity = 20,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    }
            );
        }
    }
}
