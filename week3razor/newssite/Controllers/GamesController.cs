using Microsoft.AspNetCore.Mvc;
using jouwprojectnaam.Models; // pas aan naar jouw namespace

public class GamesController : Controller
{
    public IActionResult Index()
    {
        var games = new List<Game>
        {
            new Game { Id = 1, Title = "Hollow Knight", Platform = "PC", Genre = "Metroidvania" },
            new Game { Id = 2, Title = "Mario Kart 8", Platform = "Switch", Genre = "Racing" },
            new Game { Id = 3, Title = "The Last of Us", Platform = "PS4", Genre = "Action" }
        };

        return View(games);
    }
}
