using Microsoft.AspNetCore.Mvc;
using TaskFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskFlow.Controllers
{
    public class TaskController : Controller
    {
        private readonly AppDbContext _context;

        public TaskController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Task
        public async Task<IActionResult> Index()
        {
            var tasks = await _context.TaskItems.ToListAsync();
            return View(tasks);
        }

        // GET: /Task/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Task/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskItem task)
        {
            if (ModelState.IsValid)
            {
                _context.TaskItems.Add(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        // GET: /Task/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var task = await _context.TaskItems.FindAsync(id);
            if (task == null) return NotFound();
            return View(task);
        }

        // POST: /Task/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TaskItem task)
        {
            if (id != task.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.TaskItems.Update(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        // POST: /Task/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var task = await _context.TaskItems.FindAsync(id);
            if (task != null)
            {
                _context.TaskItems.Remove(task);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
