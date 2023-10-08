namespace DaprDemo.Ordering.Domain
{
    // public record OrderItem(int Id, int ProductId, int Quantity, int OrderId, Order? Order);
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }
    }
}