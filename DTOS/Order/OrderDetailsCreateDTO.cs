namespace E_Commerce_C_.DTOS.Order
{
    public class OrderDetailsCreateDTO
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public required string ItemName { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
