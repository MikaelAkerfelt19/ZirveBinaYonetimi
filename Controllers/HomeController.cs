using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ZirveBinaYonetimi.Models;

namespace ZirveBinaYonetimi.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Corporate()
    {
        return View();
    }
    public IActionResult Process()
    {
        return View();
    }
    public IActionResult References()
    {
        return View();
    }
    public IActionResult GetQuote()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Services()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
