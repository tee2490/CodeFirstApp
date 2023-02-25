using CodeFirstApp.Models;

namespace CodeFirstApp.Services
{
    public interface IProductService
    {
        void GenerateProduct(int number);
        IEnumerable<Product> GetProduct();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Product FindProduct(int id);
        void DeleteProduct(int id);
    }
}
