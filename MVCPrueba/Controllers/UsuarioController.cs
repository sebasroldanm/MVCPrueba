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
                    //ModelState.AddModelError("", "Error al registrar Usuario" + ex.Message);
                    ModelState.AddModelError("", "Error al registrar Usuario");
                    return View();
                }
                
            }
        }

        public ActionResult Editar(int id)
        {
            try
            {
                using (var db = new Mapeo("public"))
                {
                    //Usuario result = db.usuario.Where(x => x.id_usua == id).FirstOrDefault();
                    Usuario result = db.usuario.Find(id);             //Solo cuando es unico, No compuesta la llave primaria
                    return View(result);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al traer Usuario");
                return View();
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Usuario enc)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                    //ModelState.AddModelError("","Ha ocurrido un problema, seleccione todo");
                }
                else
                {
                    using (var db = new Mapeo("public"))
                    {
                        Usuario edit = db.usuario.Find(enc.id_usua);
                        edit.apellido_usua = enc.apellido_usua;
                        edit.ciu_nacimiento = enc.ciu_nacimiento;
                        edit.clave = enc.clave;
                        edit.correo = enc.correo;
                        edit.dep_nacimiento = enc.dep_nacimiento;
                        edit.direccion = enc.direccion;
                        edit.estado = enc.estado;
                        edit.fecha_nac = enc.fecha_nac;
                        edit.foto_usua = "skjdshfbsdhfbsdhbfsd.jpeg";
                        edit.nombre_usua = enc.nombre_usua;
                        edit.num_documento = enc.num_documento;
                        edit.rol_id = enc.rol_id;
                        edit.sesion = Session.SessionID;
                        edit.state_t = "1";
                        edit.telefono = enc.telefono;
                        edit.user_name = enc.user_name;

                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al editar Usuario");
                return View();
            }
        }

        public ActionResult DetalleUsuario(int id)
        {
            try
            {
                using (var db = new Mapeo("public"))
                {
                    Usuario result = db.usuario.Find(id);
                    return View(result);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al traer Usuario");
                return View();
            }
        }

        public ActionResult EliminarUsuario(int id)
        {
            try
            {
                using (var db = new Mapeo("public"))
                {
                    Usuario result = db.usuario.Find(id);
                    db.usuario.Remove(result);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al traer Usuario");
                return View();
            }
        }




    }
}