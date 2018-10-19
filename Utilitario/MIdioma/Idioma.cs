using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utilitario.MIdioma
{
    [Serializable]
    [Table("idioma", Schema = "idioma")]
    public class Idioma
    {
        private Int32 IdIdioma;
        private String Nombre;
        private String Terminacion;

        [Key]
        [Column("id_idioma")]
        public int IdIdioma1 { get => IdIdioma; set => IdIdioma = value; }

        [Required]
        [Column("nombre")]
        public string Nombre1 { get => Nombre; set => Nombre = value; }

        [Required]
        [Column("terminacion")]
        public string Terminacion1 { get => Terminacion; set => Terminacion = value; }
    }
}
