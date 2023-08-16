using JwtOrnekProje.Dal;
using JwtOrnekProje.Models;

namespace JwtOrnekProje.Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly Context _context;


        public CategoryManager(Context context)
        {
            _context = context;
        }

        public Category GetByID(int id)
        {
            return _context.Set<Category>().Find(id);
        }

        public void TDelete(Category t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public List<Category> TGetList()
        {
            return _context.Set<Category>().ToList();
        }

        public void TInsert(Category t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void TUpdate(Category t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
