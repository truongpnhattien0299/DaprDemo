namespace DaprDemo.Inventory.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public int BrandId { get; set; }
        public Brand? Brand { get; set; } = null;
        public int ProductTypeId { get; set; }
        public ProductType? ProductType { get; set; } = null;

        public Product(int id, string name, int quantity, int price, int brandId, int productTypeId)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            BrandId = brandId;
            ProductTypeId = productTypeId;
        }

        public int DecreaseQuantity(int minusQuantity)
        {
            Quantity -= minusQuantity;
            return minusQuantity;
        }
    }
}
