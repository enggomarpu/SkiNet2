using Microsoft.EntityFrameworkCore;
using TCCMS.Domain.Entities;
using TCCMS.Domain.Interfaces;
using TCCMS.Infrastructure.Persistance;

namespace TCCMS.Infrastructure.Repositories.Products
{
    public class ProductRepository: IProductRespository
    {
        private readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var products = await _dbContext.Products.ToListAsync();
            return products;
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            return product;
        }
    }
}
