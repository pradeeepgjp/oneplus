using Microsoft.AspNetCore.Mvc;
using oneplus.Data;
using oneplus.Models;
using System.Diagnostics;

namespace oneplus.Controllers
{
    public class HomeController : Controller
    {
        private readonly IyalDbContext _Db;

        public HomeController(IyalDbContext Db)
        {
            _Db = Db;
        }


        public IActionResult Index()
        {

            return View();
        }
        public IActionResult About()
        {

            return View();
        }
        public IActionResult Contact()
        {

            return View();
        }
        public IActionResult Furniture()
        {

            return View();
        }
        public IActionResult Login(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Iyal? a = _Db.IyalList.Find(id);
            if (a == null)
            {
                return NotFound();
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(Iyal v)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(Iyal x)
        {
            if (ModelState.IsValid)
            {
                _Db.IyalList.Add(x);
                _Db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Shop()
        {

            return View();
        }


      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}