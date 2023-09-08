using System.Diagnostics;
using Context.TaskContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskApp.Models;

namespace TaskApp.Controllers;

public class HomeController : Controller
{
    private readonly TaskContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger,TaskContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var dataApp =  _context.App.ToList();
        return View(dataApp);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }

    public async Task<IActionResult> Tareas(int Id){
        var dataTask = await _context.Tasks.Where(x=>x.IdApp ==Id).ToListAsync();
        return View(dataTask);
    }
}
