namespace E_Commerce_C_.Model
{
    public class CartItem
    {
        public int Id { get; set; }
        public int ProductItemId { get; set; }
        [ForeignKey("ProductItemId")]
        public Product Products { get; set; } = new();
        public int Quantity { get; set; }
        public int ShoppingCartId { get; set; }
    }
}
