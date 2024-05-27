namespace E_Commerce_C_.Repository.Interface
{
    public interface IShoppingCartRepository
    {
        List<ShoppingCart> GetAll();

        ShoppingCart GetById(int id);

        void Insert(ShoppingCart obj);

        void Update(ShoppingCart obj);

        void Delete(int id);

        void Save();
    }
}
