using Microsoft.AspNetCore.Mvc;
using MindTrack.Models;

namespace MindTrack.Controllers
{
    public class FocusController : Controller
    {
        private static readonly List<FocusRecord> _data = new()
        {
            new FocusRecord { Id = 1, Inicio = DateTime.Now.AddMinutes(-45), Fim = DateTime.Now, Humor = "Motivado" }
        };

        private static int _idSeed = _data.Max(x => x.Id);

        public IActionResult Index()
        {
            return View(_data);
        }

        public IActionResult Create() => View(new FocusRecord());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FocusRecord model)
        {
            model.Id = ++_idSeed;
            _data.Add(model);
            TempData["ok"] = "Sessão registrada com sucesso!";
            return RedirectToAction(nameof(Index));
        }
    }
}
