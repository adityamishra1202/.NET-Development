using _5_July.Models;

namespace _5_July.Repository
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product GetProduct(int id);

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int id);
    }
}
