using TCCMS.Domain.Entities;

namespace TCCMS.Domain.Interfaces
{
    public interface IProductRespository
    {

        Task<Product> GetProduct(int id);

        Task<IEnumerable<Product>> GetAllProducts();

    }
}
