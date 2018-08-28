using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public void CalculaSaque(int saque)
        {
            /*
            int value = saque;

            int nota100 = 0;
            int nota50 = 0;
            int nota20 = 0;
            int nota10 = 0;
            int nota5 = 0;
            int nota2 = 0;

            if (value % 2 != 0 && value > 5)
            {
                value -= 5;
                nota5 += 1;
            }
            nota100 = value / 100;
            nota50 = (value % 100) / 50;
            nota20 = ((value % 100) % 50) / 20;
            nota10 = (((value % 100) % 50) % 20) / 10;
            nota5 = ((((value % 100) % 50) % 20) % 10) / 5;
            nota2 = (((((value % 100) % 50) % 20) % 10) % 5) / 2;

            if (value != 0)
            {
                Console.WriteLine("Evetuação de saque indisponível");
            }
            else
            {
                Console.WriteLine("Passou");   
            }
            */
            return;
        }
    }
}