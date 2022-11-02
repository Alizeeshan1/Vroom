using Microsoft.AspNetCore.Mvc;
using Vroom.AppDbContext;

namespace Vroom.Controllers
{
    public class MakeController : Controller
    {
        private readonly VroomDbContext _db;
        public MakeController(VroomDbContext db)
        {
            _db = db;   
        }
        public IActionResult Index()
        {
            return View(_db.Makes.ToList());
        }
    }
}
