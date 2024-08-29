using TCCMS.Domain.Entities;

namespace TCCMS.Domain.Specification
{
    public class ProductWithBrandAndType : BaseSpecification<Product>
    {
        public ProductWithBrandAndType()
        {
            AddInclude(p => p.ProductType);
            AddInclude(p => p.ProductBrand);

        }
    }
}
