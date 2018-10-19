using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitario.MUsuario;

namespace Data
{
    public class DUser
    {
        public void insertarUserMapeo(Usuario user)
        {
            using (var db = new Mapeo("public"))
            {
                db.usuario.Add(user);
                db.SaveChanges();
            }
        }





    }
}
