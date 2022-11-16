using Microsoft.AspNetCore.Mvc;
using StudentProgressReportSystem.Models;

namespace StudentProgressReportSystem.Controllers
{
    public class StudentController : Controller
    {
        public DatabaseContext _context;
        public StudentController(DatabaseContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                var st = new Student()
                {
                    Name = s.Name,
                    Email = s.Email,
                    DateOfBirth=s.DateOfBirth,
                    Description = s.Description


                };
                _context.Students.Add(st);
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
        public IActionResult Remove(int id)
        {
            var st = _context.Students.SingleOrDefault(s => s.Id == id);
            _context.Students.Remove(st);
            _context.SaveChanges();
            TempData["msg"] = "Successfully Deleted";
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var s = _context.Students.SingleOrDefault(st => st.Id == id);
            return View(s);
        }
        [HttpPost]
        public IActionResult Edit(Student s)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Update(s);
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