using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utilitario.MRegistro
{
    [Serializable]
    [Table("materia", Schema = "registro")]
    public class Materia
    {
        Int32 idMateria;
        String nombreMateria;
        String Sesionm;
        String ultimaModificacion;

        [Key]
        [Column("id_materia")]
        public int IdMateria { get => idMateria; set => idMateria = value; }

        [Required]
        [Display(Name = "Nombre Materia")]
        [Column("nombre_materia")]
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }

        [Column("sesion")]
        public string Sesionm1 { get => Sesionm; set => Sesionm = value; }

        [Column("ultima_modificacion")]
        public string UltimaModificacion { get => ultimaModificacion; set => ultimaModificacion = value; }
    }
}
