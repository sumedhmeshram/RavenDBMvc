using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RavenDb.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Person()
        { 
           List<Person> persons = new List<Person>{
                                                    new Person{Id = 1,FirstName = "Rennish",LastName=null},
                                                    new Person{Id = 1,FirstName = "Rennish",LastName="Joseph"},
                                                    new Person{Id = 1,FirstName = "Anu",LastName="Joseph"}
           
                                                  };
           return View(persons);
        }
    }

    public class Person
    {
        [Display(Name="Person ID")]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}