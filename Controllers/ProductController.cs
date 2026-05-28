using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    public IActionResult View1()
    {
        return View();
    }

    public IActionResult View2(int id)
    {
        return View();
    }
}