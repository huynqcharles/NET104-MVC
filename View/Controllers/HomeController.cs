using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using View.Models;
using View.Models.ViewModels;

namespace View.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Dictionary<string, string> tuDien = new Dictionary<string, string>();
        // tuDien.Add("hello", "xin chao");
        // tuDien.Add("goodbye", "tam biet");
        //
        // foreach (var word in tuDien)
        // {
        //     Console.WriteLine($"Nghia cua tu {word.Key} la {word.Value}");
        // }
        // var students = new List<Student>();
        //
        // students.Add(
        //     new Student()
        //     {
        //         StudentId = 101,
        //         Name = "James",
        //         Branch = "CSE",
        //         Section = "A",
        //         Gender = "Male"
        //     }
        //     );
        // students.Add(
        //     new Student()
        //     {
        //         StudentId = 102,
        //         Name = "James 2",
        //         Branch = "CSE",
        //         Section = "A",
        //         Gender = "Male"
        //     }
        // );
        //
        //
        // ViewData["listStudents"] = students;
        // ViewBag.ListStudent = students;
        // return View(students);
        
        //Student Basic Details
        // Student student = new Student()
        // {
        //     StudentId = 101,
        //     Name = "Dillip",
        //     Branch = "CSE",
        //     Section = "A",
        //     Gender = "Male",
        //     Mark = 6
        // };
        // //Student Address
        // Address address = new Address()
        // {
        //     StudentId = 101,
        //     City = "Mumbai",
        //     State = "Maharashtra",
        //     Country = "India",
        //     Pin = "400097"
        // };
        // //Creating the View model
        // StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
        // {
        //     Student = student,
        //     Status = student.Mark >= 5 ? "PASS" : "FAILED"
        // };
        //
        // return View(studentDetailsViewModel);

        TempData["Name"] = "nguyen quang huy";
        
        TempData.Keep("Name");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult MyPartialView()
    {
        return PartialView("_MyPartialView");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}