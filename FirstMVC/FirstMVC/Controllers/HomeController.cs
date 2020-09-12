using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models; 

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index()
        {
            return "Hello, This is my first MVC application !!!";
        }

        public string Greet(string name)
        {
            return string.Format("Hello {0}, this is my first ASP.NET MVC application", "John"); 
        }


        public ActionResult ShowDetails(string name)
        {
            ViewBag.Message = "Hello Rajan";
            ViewBag.YourID = "10";

            return View(); 
        }

        public ActionResult CustomerDetails()
        {
            Customer cust = new Customer();
            cust.CustomerID = "ALFKI";
            cust.CompanyName = "Alfreds Futterkiste";
            cust.Age = 20;
            cust.JoinDate = DateTime.Now.AddYears(-4);
            cust.Email = "abc@amail.com";
            cust.CustomerType = EnumCustomerType.New; 

            return View(cust);
        }


        [HttpPost]
        public ActionResult CustomerDetails(Customer cust)
        {
            
            //code to update Customer details in database
            return View();
        }
    }
}
