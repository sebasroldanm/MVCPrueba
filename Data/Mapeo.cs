using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitario.MUsuario;

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
    }
}
