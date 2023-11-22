using Microsoft.AspNetCore.Mvc;

namespace Model_Binding.Controllers;

public class FromHeaderController : Controller
{
    // GET
    public IActionResult Index([FromHeader(Name = "Method")] string method)
    {
        return Content(method);
    }
}