using RavenDb.Web.Models;
using System;
using System.Collections.Generic;
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
            List<PersonViewModel> persons = new List<PersonViewModel>{
                                                    new PersonViewModel{Id = 1,FirstName = "Rennish"},
                                                    new PersonViewModel{Id = 2,FirstName = "Tny",LastName="Abraham"},
                                                    new PersonViewModel{Id = 3,LastName="Jose"}
                                                  };
            return View(persons);
        }
    }
}