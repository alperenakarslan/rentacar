using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Rent_a_Car_Project.Models.Siniflar;

namespace Rent_a_Car_Project.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Loginn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Loginn(Admin ad)
        {
            var bilgiler = c.admins.FirstOrDefault(x => x.userName == ad.userName && x.password == ad.password);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.userName, false);
                Session["userName"] = bilgiler.userName.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Loginn", "Login");
        }
    }
}