using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitario.MUsuario
{
    [Serializable]
    [Table("usuario", Schema = "usuario")]
    public class Usuario
    {
        private Int32 userId;
        private String nombre;
        private String userName;
        private String rol;
        private String Clave;
        private String Correo;
        private Boolean Estado;
        private String apellido;
        private String Direccion;
        private String Telefono;
        private String documento;
        private String foto;
        private String Fecha_nacimiento;
        private String departamento;
        private String ciudad;
        private String sesion1;
        private string stateT;

        [Key]
        
        [Column("id_usua")]
        public int id_usua { get => userId; set => userId = value; }

        [Required]
        [Column("nombre_usua")]
        public string nombre_usua { get => nombre; set => nombre = value; }

        [Required]
        [Display(Name = "Ingrese Nombres")]
        [Column("user_name")]
        public string user_name { get => userName; set => userName = value; }

        [Required]
        [Column("rol_id")]
        public string rol_id { get => rol; set => rol = value; }

        [Required]
        [Column("clave")]
        public string clave { get => Clave; set => Clave = value; }

        [Column("correo")]
        public string correo { get => Correo; set => Correo = value; }

        [Required]
        [Column("estado")]
        public Boolean estado { get => Estado; set => Estado = value; }

        [Required]
        [Column("apellido_usua")]
        public string apellido_usua { get => apellido; set => apellido = value; }

        [Required]
        [Column("direccion")]
        public string direccion { get => Direccion; set => Direccion = value; }

        //[Required]
        [Column("telefono")]
        public string telefono { get => Telefono; set => Telefono = value; }

        [Required]
        [Column("num_documento")]
        public string num_documento { get => documento; set => documento = value; }

        //[Required]
        [Column("foto_usua")]
        public string foto_usua { get => foto; set => foto = value; }

        [Required]
        [Column("fecha_nac")]
        public string fecha_nac { get => Fecha_nacimiento; set => Fecha_nacimiento = value; }

        [Required]
        [Column("dep_nacimiento")]
        public string dep_nacimiento { get => departamento; set => departamento = value; }

        [Required]
        [Column("ciu_nacimiento")]
        public string ciu_nacimiento { get => ciudad; set => ciudad = value; }

        //[Required]
        [Column("sesion")]
        public string sesion { get => sesion1; set => sesion1 = value; }

        //[Required]
        [Column("state_t")]
        public string state_t { get => stateT; set => stateT = value; }
    }
}
