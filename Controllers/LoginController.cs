using MyFirstProject_C.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstProject_C.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
       public ActionResult Login()
        {            
                return View();
        }

        // GET: Login
        [HttpPost]
        public ActionResult Login(LoginData logindt)
        {
            EmployeeRepository empRepo = new EmployeeRepository();
            if (empRepo.validateLogin(logindt))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("InvalidLogin", "Invalid Credentials");
            }

            return View();
        }
    }
}