namespace E_Commerce.API.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string? url { get; set; }

        public int CategoryId { get; set; }
        //nav prop
        public Category Category { get; set; }
    }
}
