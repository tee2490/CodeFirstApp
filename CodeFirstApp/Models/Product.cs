namespace CodeFirstApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Test";
        public double Price { get; set; } = 10;
        public int Amount { get; set; } = 20;
    }
}
