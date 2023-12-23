namespace TechCareer_.NetCoreBootcamp.Models
{
    public class Product
    {
        public Product(int id, string name, decimal unitPrice, Category category)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            Category = category;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public Category Category { get; set; }
    }
}
