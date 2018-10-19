using System;
using System.Linq;
using System.Web.Mvc;
using System.Data;
using Utilitario.MUsuario;
using System.Data.Entity;
using System.Collections.Generic;
using Data;

namespace MVCPrueba.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {

            using (var db = new Mapeo("public"))
            {
                //db.usuario.ToList<Usuario>();

                return View(db.usuario.ToList());
            }

        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Agregar(Usuario enc)
        {
            if (!ModelState.IsValid)
            {
                return View();
                //ModelState.AddModelError("","Ha ocurrido un problema, seleccione todo");
            }
            else
            {
                enc.sesion = Session.SessionID;
                enc.state_t = "1";
                enc.foto_usua = "skjdshfbsdhfbsdhbfsd.jpeg";
                try
                {
                    using (var db = new Mapeo("public"))
                    {
                        db.usuario.Add(enc);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error al registrar Usuario" + ex.Message);
                    return View();
                }
                
            }
        }

        public ActionResult Editar(int id)
        {
            using (var db = new Mapeo("public"))
            {
                //Usuario result = db.usuario.Where(x => x.id_usua == id).FirstOrDefault();
                Usuario result = db.usuario.Find(id);             //Solo cuando es unico, No compuesta la llave primaria
                return View(result);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Usuario enc)
        {
            return View();
        }







    }
}