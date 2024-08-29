using TCCMS.Domain.Entities;

namespace TCCMS.Domain.Specification
{
    public class ProductWithBrandAndType : BaseSpecification<Product>
    {
        public ProductWithBrandAndType(int id) : base(p => p.Id == id)
        {
            
        }
        public ProductWithBrandAndType()
        {
            AddInclude(p => p.ProductType);
            AddInclude(p => p.ProductBrand);

        }

        public ProductWithBrandAndType(bool productBrand, bool productType)
        {
            if (productBrand) { 
                AddInclude(p => p.ProductBrand);
            }

            if (productType)
            {
                AddInclude(p => p.ProductType);
            }
            

        }

    }
}
