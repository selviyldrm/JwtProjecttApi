using JwtOrnekProje.Dal;
using JwtOrnekProje.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtOrnekProje.Services
{
    public class ProductManager : IProductService
    {
        private readonly Context _context;

        public ProductManager(Context context)
        {
            _context = context;
        }

        public Product GetByID(int id)
        {
            return _context.Set<Product>().Find(id);
        }

        public void TDelete(Product t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public List<Product> TGetList()
        {
            return _context.Set<Product>().ToList();
        }

        public void TInsert(Product t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void TUpdate(Product t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
        public List<Product> GetProductWithCategories()
        {
           
            return _context.Products.Include(x => x.Category).ToList();
        }
    }
}
