using Microsoft.AspNetCore.Mvc;

namespace Model_Binding.Controllers;

public class NoModelBindingController : Controller
{
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(IFormCollection form)
    {
        var name = HttpContext.Request.Form["UserName"].ToString();
        var email = HttpContext.Request.Form["UserEmail"].ToString();
        return View();
    }
}