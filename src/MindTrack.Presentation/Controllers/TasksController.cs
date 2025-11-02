using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MindTrack.Models;
using MindTrack.Models.Enums;
using MindTrack.Repositories;

using TaskStatusEnum = MindTrack.Models.Enums.TaskStatus;

namespace MindTrack.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITasksRepository _repo;

        public TasksController(ITasksRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(string? termo, Priority? prioridade, TaskStatusEnum? status)
        {
            ViewBag.Prioridades = new SelectList(Enum.GetValues(typeof(Priority)));
            ViewBag.Statuses = new SelectList(Enum.GetValues(typeof(TaskStatusEnum)));
            ViewBag.Termo = termo;
            ViewBag.Prioridade = prioridade;
            ViewBag.Status = status;

            var data = _repo.GetAll(termo, prioridade, status);
            return View(data);
        }

        public IActionResult Details(int id)
        {
            var item = _repo.GetById(id);
            if (item == null) return NotFound();
            return View(item);
        }

        public IActionResult Create() => View(new TaskItem());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TaskItem model)
        {
            if (!ModelState.IsValid) return View(model);

            _repo.Add(model);
            TempData["ok"] = "Tarefa criada com sucesso!";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var item = _repo.GetById(id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, TaskItem model)
        {
            if (id != model.Id) return BadRequest();
            if (!ModelState.IsValid) return View(model);

            _repo.Update(model);
            TempData["ok"] = "Tarefa atualizada!";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var item = _repo.GetById(id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _repo.Delete(id);
            TempData["ok"] = "Tarefa removida!";
            return RedirectToAction(nameof(Index));
        }
    }
}
