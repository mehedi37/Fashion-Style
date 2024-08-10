using Fashion___Style.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fashion___Style.Controllers
{
    public class HomeController(FashionContext context) : Controller
    {
        private readonly FashionContext _context = context;

        public IActionResult Index()
        {
            List<FashionModel> fashionModels = _context.FashionModels.ToList();
            return View(fashionModels);
        }

        public IActionResult AddFashion()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddFashion(FashionModel fashionModel)
        {
            if (ModelState.IsValid)
            {
                _context.FashionModels.Add(fashionModel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fashionModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
