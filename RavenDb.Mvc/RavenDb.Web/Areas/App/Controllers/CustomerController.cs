using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RavenDb.Web.Controllers
{
    public class CustomerController : Controller
    {
        
        public ActionResult Index()
        {
           
            return View();
        }
    }
}