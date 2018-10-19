using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Utilitario.MUsuario;

namespace Logica
{
    public class LUser
    {
        public void insertarUserMapeo(Usuario text)
        {
            DUser dao = new DUser();
            dao.insertarUserMapeo(text);
        }






    }
}
