using System.Data.Entity;
using Utilitario.MUsuario;
using Utilitario.MRegistro;
using Utilitario.MIdioma;
using Utilitario.MInicio;

namespace Data
{
    public class Mapeo : DbContext
    {
        static Mapeo()
        {
            Database.SetInitializer<Mapeo>(null);
        }
        private readonly string schema;

        public Mapeo(string schema)
            : base("name=Postgres")
        {
            this.schema = schema;
        }

        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Idioma> idioma { get; set; }
        public DbSet<Inicio> inicio { get; set; }
        public DbSet<Materia> materia { get; set; }
    }
}
