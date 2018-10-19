using System;
using System.Linq;
using System.Web.Mvc;
using Utilitario.MUsuario;
using Data;
using System.Collections.Generic;

namespace MVCPrueba.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: Administrador
        public ActionResult Index()
        {
            using (var db = new Mapeo("public"))
            {
                List<Usuario> lista = db.usuario.Where(x => x.rol_id == "1").ToList();
                return View(lista);
            }
        }
    }
}