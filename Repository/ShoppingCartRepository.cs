namespace E_Commerce_C_.Repository
{
    public class ShoppingCartRepository:IShoppingCartRepository
    {
        ApplicationDbContext context;

        // Inject Context
        public ShoppingCartRepository(ApplicationDbContext _context)
        {
            context = _context;
        }
        public List<ShoppingCart> GetAll()
        {
            return context.ShoppingCarts.ToList();
        }
        public ShoppingCart GetById(int Id)
        {
            return context.ShoppingCarts.FirstOrDefault(P => P.Id == Id);
        }
        public void Insert (ShoppingCart obj)
        {
            context.Add(obj);
        }
        public void Update(ShoppingCart obj)
        {
            context.Update(obj);
        }
        public void Delete(int id)
        {
            ShoppingCart crs = GetById(id);
            context.Remove(crs);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
