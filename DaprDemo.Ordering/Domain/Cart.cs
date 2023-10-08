namespace DaprDemo.Ordering.Domain
{
    public class Cart
    {
        public string? UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}