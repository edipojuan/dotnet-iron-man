using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Store.Models;
using Store.Repositories;

namespace Store.Controllers
{
  [Route("v1")]
  public class HomeController : Controller
  {

    private readonly ProductRepository _repository;

    public HomeController(ProductRepository repository)
    {
      _repository = repository;
    }

    [Route("")]
    [HttpGet]
    public IEnumerable<Product> Get()
    {
      return _repository.Get();
    }
  }
}