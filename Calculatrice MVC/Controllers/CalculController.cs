using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculatrice_MVC.Models;

namespace Calculatrice_MVC.Controllers
{
    public class CalculController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculatrice c, string command)
        {
            switch (command)
            {
                case "Add":
                    c.result = c.a + c.b;
                    break;
                case "Sub":
                    c.result = c.a - c.b;
                    break;
                case "Mul":
                    c.result = c.a * c.b;
                    break;
                case "Div":
                    c.result = c.a / c.b;
                    break;
            }
            
            return View("Index",c);
        }
    }
}