using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using MvcApplication1.Models;

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

        public ActionResult MyCollection()
        {
            var oVm = new MyViewModel
            {
                CustomerName = "pop",
                hobbies = new List<Hobbies>
                {
                    new Hobbies {ID=1,Name="Foot ball",IsSelected=false},
                    new Hobbies {ID=2,Name="Table Tennis",IsSelected=false},
                    new Hobbies {ID=3,Name="Cricket",IsSelected=false},
                    new Hobbies {ID=4,Name="Web Surfing",IsSelected=false},
                    new Hobbies {ID=5,Name="Listening Music",IsSelected=false}
                },

                movies = new List<Movies>
                {
                    new Movies {ID=1,Name="Blood Sports",IsSelected=false},
                    new Movies {ID=2,Name="Good Kill",IsSelected=false},
                    new Movies {ID=3,Name="Avtar",IsSelected=false},
                    new Movies {ID=4,Name="Lost Africa",IsSelected=false},
                    new Movies {ID=5,Name="The Hell",IsSelected=false}
                }
            };

            return View(oVm);
        }

        [HttpPost]
        public ActionResult MyCollection(MyViewModel oVm, string CustomerName)
        {
            ViewBag.Message = "Success";
            return View(oVm);
        }


        [Authorize]
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

        public ActionResult Form1()
        {
            Register rgs = new Register();
            return View(rgs);
        }

        [HttpPost]
        public ActionResult Form1(Register rgs)
        {
            if (rgs.FName.Length<10)
            {
                ViewBag.Message = "FAIL";
            }
            else
            {
                ViewBag.Message = "SUCCESS";
            }
            return View(rgs);
        }

        public string SayHi()
        {
            return "hi from 'SayHi'.";
        }  
    }

    public class Register
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public bool IsApproved { get; set; }
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
