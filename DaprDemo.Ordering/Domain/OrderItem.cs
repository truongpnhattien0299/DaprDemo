namespace DaprDemo.Ordering.Domain
{
    // public record OrderItem(int Id, int ProductId, int Quantity, int OrderId, Order? Order);
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int id, int productId, int quantity, int orderId)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.ProductId = productId;
            this.OrderId = orderId;

        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }

    }
}