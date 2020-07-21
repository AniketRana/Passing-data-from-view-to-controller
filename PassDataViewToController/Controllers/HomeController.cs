using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PassDataViewToController.Models;

namespace PassDataViewToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string PostUsingParameters(string Fname,string Lname) 
        {
            return "From Parameters FirstName = " +Fname +" and LastName =" +Lname;
        }

        [HttpPost]
        public string PostUsingRequest()
        {
            string Fname = Request["Fname"]; 
            string Lname = Request["Fname"];
            return "From Request FirstName = " + Fname + " and LastName =" + Lname;
        }

        [HttpPost]
        public string PostUsingFormCollection(FormCollection form) 
        { 
            string Fname = form["Fname"];
            string Lname = form["Fname"];
            return "From form collection FirstName = " + Fname + " and LastName =" + Lname;
        }

        [HttpPost]
        public string PostUsingStronglyBinding(emp emp) 
        {
            return "From Strongly Binding FirstName = " + emp.Fname + " and LastName =" + emp.Lname;
        }
    }
}