using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostServer.Host
{
    public class OrdersController : ApiController
    {
        Order[] orders = new Order[]
        {
            new Order { Id = 1, Name = "HeadPhones", Category = "Electronics", Price = 19.5M },
            new Order { Id = 2, Name = "Phone", Category = "Electronics", Price = 210.99M },
            new Order { Id = 3, Name = "Pajamas", Category = "Clothing", Price = 22 },
            new Order { Id = 4, Name = "Cutting Board", Category = "Home and Kitchen", Price = 5 }
        };

        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }
    }
    
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Product 1" },
            new Product { Id = 2, Name = "Product 2" },
            new Product { Id = 3, Name = "Product 3" },
            new Product { Id = 4, Name = "Product 4" },
            new Product { Id = 5, Name = "Product 5" }
        };

        [HttpGet]
        public IEnumerable<Product> AllProducts()
        {
            return products;
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}