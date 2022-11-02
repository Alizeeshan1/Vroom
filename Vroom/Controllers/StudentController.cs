using Microsoft.AspNetCore.Mvc;
using Vroom.AppDbContext;
using Vroom.Models;

namespace Vroom.Controllers
{
    public class StudentController : Controller
    {
        private readonly VroomDbContext _db;
        public StudentController(VroomDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_db.Students.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(student);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

    }
}
