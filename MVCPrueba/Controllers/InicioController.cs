using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utilitario.MInicio;

namespace MVCPrueba.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult Index()
        {
            using (var db = new Mapeo("public"))
            {
                return View(db.inicio.ToList());
            }
        }
    }
}