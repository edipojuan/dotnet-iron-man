using System.Collections.Generic;
using Store.Models;

namespace Store.Repositories
{
  public class ProductRepository
  {
    public IEnumerable<Product> Get()
    {
      var products = new List<Product>();
      products.Add(new Product { Title = "Título do Produto" });
      return products;
    }
  }
}