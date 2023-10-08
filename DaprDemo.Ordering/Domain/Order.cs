namespace DaprDemo.Ordering.Domain
{
    public class Order
    {

        public Order(int id, string UserId)
        {
            this.Id = id;
            this.CreatedAt = DateTime.Now;
            this.UserId = UserId;
        }
        public int Id { get; set; }
        public string? UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }

    }
}