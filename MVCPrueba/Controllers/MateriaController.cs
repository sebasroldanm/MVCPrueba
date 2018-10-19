using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Utilitario.MRegistro;

namespace MVCPrueba.Controllers
{
    public class MateriaController : Controller
    {
        // GET: Materia
        public ActionResult Index()
        {
            using (var db = new Mapeo("public"))
            {
                return View(db.materia.ToList());
            }
        }
    }
}