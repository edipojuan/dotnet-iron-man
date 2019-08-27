using System;
using System.Collections.Generic;

namespace Store.Models
{
  public class Category
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public IEnumerable<Product> Products { get; set; }
  }
}