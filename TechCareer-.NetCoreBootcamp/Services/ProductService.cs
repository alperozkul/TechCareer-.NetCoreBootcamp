using TechCareer_.NetCoreBootcamp.Models;

namespace TechCareer_.NetCoreBootcamp.Services
{
    public class ProductService
    {
        public static List<Product> GetAllProduct()
        {
            var categories = GetAllCategory();
            var products = new List<Product>();
            products.Add(new Product(1, "Samsung S23", 50000, categories.FirstOrDefault(x => x.Name == "Telefon")));
            products.Add(new Product(2, "Iphone 15 Pro", 70000, categories.FirstOrDefault(x => x.Name == "Telefon")));
            products.Add(new Product(3, "Lenovo Ideapad", 30000, categories.FirstOrDefault(x => x.Name == "Bilgisayar")));
            products.Add(new Product(4, "Asus Zenbook", 40000, categories.FirstOrDefault(x => x.Name == "Bilgisayar")));
            return products;
        }

        public static List<Category> GetAllCategory()
        {
            var categories = new List<Category>();
            categories.Add(new Category(1, "Telefon"));
            categories.Add(new Category(2, "Bilgisayar"));
            return categories;
        }
    }
}
