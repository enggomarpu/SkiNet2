using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TCCMS.Domain.Entities;


namespace TCCMS.Infrastructure.Configuration
{
    public class ProductBrandConfiguration : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.HasData
            (
            new ProductBrand
            {
                Id = 1,
                Name = "Angular"
            },
            new ProductBrand
            {
                Id = 2,
                 Name = "NetCore"
            },
             new ProductBrand
             {
                 Id = 3,
                 Name = "VS Code"
             },
              new ProductBrand
              {
                  Id = 4,
                  Name = "React"
              },
               new ProductBrand
               {
                   Id = 5,
                   Name = "Typescript"
               },
               new ProductBrand
               {

                   Id = 6,
                   Name = "Redis"
               }
            );
        }
    }
}
