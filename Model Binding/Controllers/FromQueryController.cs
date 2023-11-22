using Microsoft.AspNetCore.Mvc;

namespace Model_Binding.Controllers;

public class FromQueryController : Controller
{
    // GET
    public IActionResult Index([FromQuery(Name = "n")] string name, string age)
    {
        var result = $"{name} is {age} years old.";
        return Content(result);
    }
}