using Microsoft.AspNetCore.Mvc;
using Model_Binding.Models;

namespace Model_Binding.Controllers;

public class FromFormController : Controller
{
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index([FromForm] User user)
    {
        return View();
    }
}