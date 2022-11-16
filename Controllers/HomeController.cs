using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SalonAutosport.Models;

namespace SalonAutosport.Controllers
{
    public class HomeController : Controller
    {
        AutosportContext db;
        public HomeController(AutosportContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Auto.ToList());
        }

        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.AutoId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order.Buyer + " , Благодарим за покупку!";
        }
    }
}