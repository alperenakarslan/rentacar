using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rent_a_Car_Project.Models.Siniflar;

namespace Rent_a_Car_Project.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var carslist = c.cars.ToList(); 
            return View(carslist);
        
        }
    }
}