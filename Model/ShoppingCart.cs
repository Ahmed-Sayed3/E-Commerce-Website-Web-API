namespace E_Commerce_C_.Model
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        // One To Many Relation
        public ICollection<CartItem> cartItems { get; set; }

        //Not Create Table In Db
        [NotMapped] 
        public double CartTotal { get; set; }
        [NotMapped]
        public string StripPaymentIntenId { get; set; }
        [NotMapped]
        public string ClientSecret { get; set; }
    }
}
