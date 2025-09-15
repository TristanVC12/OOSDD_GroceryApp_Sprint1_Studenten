using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products;
        public ProductRepository()
        {
            products = [
                 
                
                 new Product(id:1, name: "Melk", stock: 300),
                 new Product(id:2, name: "Kaas", stock: 100),
                 new Product(id:3, name: "Brood", stock: 400),
                 new Product(id:4, name: "CornFlakes",stock: 0)
				];
        }
        public List<Product> GetAll()
        {
            return products; 
        }

        public Product? Get(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
