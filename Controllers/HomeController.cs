using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
  [Route("v1")]
  public class HomeController : Controller
  {
    [Route("")]
    [HttpGet]
    public string Get()
    {
      return "edipojuan.com.br";
    }
  }
}