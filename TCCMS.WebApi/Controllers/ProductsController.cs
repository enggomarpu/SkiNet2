using Microsoft.AspNetCore.Mvc;
using TCCMS.Domain.Entities;
using TCCMS.Domain.Interfaces;

namespace TCCMS.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IGenericRepository<Product> _productRepo;

        public ProductsController(
            IGenericRepository<Product> productRepo
        )
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _productRepo.ListAllAsync();
            return Ok(products);        
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            return Ok(product);
        }


    }
}
