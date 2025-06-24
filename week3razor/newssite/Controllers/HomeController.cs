using System.Text.Json;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using newssite.Models;

namespace newssite.Controllers;

string json = System.IO.File.ReadAllText("data/news.json");
newsItems = JsonSerializer.Deserialize<List<NewsItem>>(json);

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Privacy()
    {
        Privacy model = new Privacy();
        model.policyText = "We do not track anything";
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
