using MyFirstProject_C.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstProject_C.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ///With Static Data
            //List<Employee> emp = new List<Employee>()
            //{ 
            //new Employee{Id=1,Name="TEst",City="USA" },
            //new Employee{Id=2,Name="TEst123",City="UK" }
            //};

            EmployeeRepository empRepo = new EmployeeRepository();
            var emp=empRepo.GetEmployees();
            return View(emp);
        }

        public ActionResult EditEmployee(int id)
        {
            EmployeeRepository empRepo = new EmployeeRepository();
            empRepo.GetEmployeebyID(id);
            return View();
        }

        public ActionResult DeleteEmployee(int id)
        {
            EmployeeRepository empRepo = new EmployeeRepository();
            bool isdeleted = empRepo.deleteEmployee(id);
            if (isdeleted)
            {
                TempData["message"] = "Employee " + id + " Deleted";
                return RedirectToAction("Index", "Home");
            }
            else
                return View();



        }

    }
}

 