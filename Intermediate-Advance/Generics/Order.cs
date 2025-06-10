namespace Generics
{
    public class Order
    {
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
