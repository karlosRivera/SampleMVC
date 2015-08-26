using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Employee emp = new Employee();
            emp.Id = 101;
            emp.Name = "Raja";
            emp.Salary = 5200;
            emp.IsMale = false;
            emp.JoinDate = DateTime.Now;
            return View(emp);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        [DisplayName("My Name")]
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool IsMale { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
