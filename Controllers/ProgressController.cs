using Microsoft.AspNetCore.Mvc;
using StudentProgressReportSystem.Models;

namespace StudentProgressReportSystem.Controllers
{
    public class ProgressController : Controller
    {
        public DatabaseContext _context;
        public ProgressController(DatabaseContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var progresss = _context.progress.ToList();
            return View(progresss);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Progress p)
        {
            if (ModelState.IsValid)
            {
                var pr = new Progress()
                {
                    Sno=p.Sno,
                    Batch=p.Batch,
                    Name=p.Name,
                    Symbol=p.Symbol,
                    Science=p.Science,
                    Math=p.Math,
                    Computer=p.Computer,
                    Nepali=p.Nepali,
                    Social=p.Social,

                };
                _context.progress.Add(pr);
                _context.SaveChanges();
                TempData["msg"] = "Successfully saved";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Not valid";
                return View();
            }
        }
        public IActionResult Remove(int sno)
        {
            var pr = _context.progress.SingleOrDefault(p => p.Sno == sno);
            _context.progress.Remove(pr);
            _context.SaveChanges();
            TempData["msg"] = "Successfully Deleted";
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int sno)
        {
            var p = _context.progress.SingleOrDefault(pr => pr.Sno == sno);
            return View(p);
        }
        [HttpPost]
        public IActionResult Edit(Progress p)
        {
            if (ModelState.IsValid)
            {
                _context.progress.Update(p);
                _context.SaveChanges();
                TempData["msg"] = "Updated Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Error occured";
                return View();
            }

        }

    }
}
