namespace JwtOrnekProje.Services
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T GetByID(int id);
    }
}