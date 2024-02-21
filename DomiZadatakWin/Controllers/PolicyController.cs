using DomiZadatakWin.Data;
using DomiZadatakWin.Models;
using Microsoft.AspNetCore.Mvc;

namespace DomiZadatakWin.Controllers
{
    public class PolicyController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PolicyController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int? id)
        {

            List<Policy> objPolicyList = _db.Policies.ToList();
            return View(objPolicyList);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Policy obj)
        {
            if (ModelState.IsValid)
            {
                _db.Policies.Add(obj);
                _db.SaveChanges();

                TempData["success"] = "Polica je uspješno kreirana!";

                return RedirectToAction("Index");

            }

            return View();

        }
    }
}
