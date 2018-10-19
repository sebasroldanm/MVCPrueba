using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utilitario.MIdioma;

namespace MVCPrueba.Controllers
{
    public class IdiomaController : Controller
    {
        // GET: Idioma
        public ActionResult Index()
        {
            using (var db = new Mapeo("public"))
            {
                return View(db.idioma.ToList());
            }
        }
    }
}