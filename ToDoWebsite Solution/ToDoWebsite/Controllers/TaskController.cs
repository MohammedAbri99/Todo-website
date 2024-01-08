using Microsoft.AspNetCore.Mvc;
using ToDoWebsite.Data;
using ToDoWebsite.Models;

namespace ToDoWebsite.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var task = _context.tasks.ToList();
            return View(task);
        }

        public IActionResult Create()
        {
            return View("Create");
        }
        public IActionResult Create(ToDoTask task)
        {
            return View(task);
        }
    }
}
