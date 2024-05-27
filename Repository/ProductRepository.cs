namespace E_Commerce_C_.Repository
{
    public class ProductRepository : IProductRepository
    {
        ApplicationDbContext context;

        // Inject Context
        public ProductRepository(ApplicationDbContext _context)
        {
            context = _context;
        }
        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }
        public Product GetById(int Id)
        {
            return context.Products.FirstOrDefault(P => P.Id == Id);
        }
        public void Insert(Product obj)
        {
            context.Add(obj);
        }
        public void Update(Product obj)
        {
            context.Update(obj);
        }
        public void Delete(int id)
        {
            Product crs = GetById(id);
            context.Remove(crs);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
