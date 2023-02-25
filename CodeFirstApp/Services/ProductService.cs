using CodeFirstApp.Data;
using CodeFirstApp.Models;

namespace CodeFirstApp.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext dataContext;
        public List<Product> products;
        public ProductService(DataContext dataContext)
        {
            this.dataContext = dataContext;

            if (this.dataContext.Products.Count() == 0)
            {
                products = new List<Product>();
                GenerateProduct(5);
            }
        }

        public void GenerateProduct(int number)
        {
            Random rnd = new Random();

            for (var i = 1; i <= number; i++)
            {
                products.Add(new Product
                {
                    Name = $"Coffee {i}",
                    Price = rnd.NextDouble() * 100 + 1,
                    Amount = rnd.Next(1, 51),
                });
            }

            dataContext.Products.AddRange(products);
            dataContext.SaveChanges();
        }

        public IEnumerable<Product> GetProduct()
        {
            return dataContext.Products;
        }

        public void AddProduct(Product product)
        {
            dataContext.Products.Add(product);
            dataContext.SaveChanges();
        }
            
        public void UpdateProduct(Product product)
        {
            dataContext.Products.Update(product);
            dataContext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = FindProduct(id);

            if (product is null) return;

            dataContext.Products.Remove(product);
            dataContext.SaveChanges();
        }

        public Product FindProduct(int id)
        {
            var product = dataContext.Products.Find(id);

            return product;
        }

    }
}
