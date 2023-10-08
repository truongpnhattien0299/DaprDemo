namespace DaprDemo.ShoppingCart.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public int BrandId { get; set; }
        public int ProductTypeId { get; set; }
    }
}
