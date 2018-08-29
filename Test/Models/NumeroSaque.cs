using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Models
{
    public class NumeroSaque
    {
        public ActionResult Value { get; set;  }
    }

    public class ValoresNotas
    {
        public ListaNotas[] ListaFinal { get; set; }
    }

    public class ListaNotas
    {
        public int Notas { get; set; }
    }
}