﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string ValorSaque)
        {
            var testSaque = ValorSaque;
            int value;

            if (testSaque == "")
            {
                value = 0;
            }
            else
            {
                value = Convert.ToInt32(testSaque);
            }

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
            nota2 = (((((value % 100) % 50) % 20) % 10) / 2);

            value = (value - ((100 * nota100) + (50 * nota50) + (20 * nota20) + (10 * nota10) + (2 * nota2)));

            if (value == 0) {
                var testModelo = new ValoresNotas()
                {
                    N100 = nota100,
                    N50 = nota50,
                    N20 = nota20,
                    N10 = nota10,
                    N5 = nota5,
                    N2 = nota2,
                    Valid = "O saque pode ser realizado"
                };
                return View(testModelo);
            }
            else
            {
                var testModelo = new ValoresNotas()
                {
                    Valid = "O saque é inválido"
                };
                return View(testModelo);
            }
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
    }
}