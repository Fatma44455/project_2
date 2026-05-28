using ITIProject.Data;
using Microsoft.AspNetCore.Mvc;

public class InstructorController : Controller
{
    MyDbContext context;

    public InstructorController(MyDbContext _context)
    {
        context = _context;
    }

    public IActionResult Index()
    {
        var data = context.Instructors.ToList();
        return View(data);
    }

    public IActionResult Details(int id)
    {
        var data = context.Instructors.FirstOrDefault(x => x.Id == id);
        return View(data);
    }
}