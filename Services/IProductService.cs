using JwtOrnekProje.Models;

namespace JwtOrnekProje.Services
{
    public interface IProductService : IGenericService<Product>
    {
        public List<Product> GetProductWithCategories();
        
    }
}
