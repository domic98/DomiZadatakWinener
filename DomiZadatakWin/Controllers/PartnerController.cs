using DomiZadatakWin.Data;
using DomiZadatakWin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DomiZadatakWin.Controllers
{
    public class PartnerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PartnerController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {

            List<Partner> objPartnerlList = _db.Partners.ToList();
            return View(objPartnerlList);
            

        }

        public IActionResult Create()
        {
            return View();
    
        }

        [HttpPost]
        
        public IActionResult Create(Partner obj)
        {
           // if (ModelState.IsValid)
           // {
                _db.Partners.Add(obj);
                _db.SaveChanges();

                TempData["success"] = "Partner je uspješno kreiran!";

                return RedirectToAction("Index");

           // }

            //return View();

        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Partner? partnerFromDb = _db.Partners.Find(id);
            if (partnerFromDb == null)
            {
                return NotFound();
            }
            return View(partnerFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Partner obj)
        {
            //if (ModelState.IsValid)
            //{
                _db.Partners.Update(obj);
                _db.SaveChanges();

                TempData["success"] = "Partner je uspješno izmijenjen!";

                return RedirectToAction("Index");

            }

            //return View();

        //}

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Partner? partnerFromDb = _db.Partners.Find(id);
            if (partnerFromDb == null)
            {
                return NotFound();
            }
            return View(partnerFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)

        {
            Partner? obj = _db.Partners.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Partners.Remove(obj);
            _db.SaveChanges();

            TempData["success"] = "Partner je uspješno uklonjen";

            return RedirectToAction("Index");

        }


        public IActionResult Details(int id)
        {
            Partner? partnerFromDb = _db.Partners.Find(id);

            if (partnerFromDb == null)
            {
                return NotFound();
            }

            return View(partnerFromDb);
        }

    }


}
