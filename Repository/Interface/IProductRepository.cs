namespace E_Commerce_C_.Repository.Interface
{
    public interface IProductRepository
    {
        List<Product> GetAll();

        Product GetById(int id);

        void Insert(Product obj);

        void Update(Product obj);

        void Delete(int id);

        void Save();
    }
}
