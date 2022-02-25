using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rent_a_Car_Project.Models.Siniflar;
namespace Rent_a_Car_Project.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.cars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewCar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCar(Cars p)
        {
            c.cars.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CarDelete(int id)
        {
            var b = c.cars.Find(id);
            c.cars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetCar(int id)
        {
            var cr = c.cars.Find(id);
            return View("GetCar", cr);
        }
        public ActionResult UpdateCar(Cars y)
        {
            var crs = c.cars.Find(y.ID);
            crs.carInfo = y.carInfo;
            crs.carImage = y.carImage;
            crs.carName = y.carName;
            crs.model = y.model;
            crs.price = y.price;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}