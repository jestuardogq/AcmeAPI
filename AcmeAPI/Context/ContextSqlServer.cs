using AcmeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AcmeAPI.Context

{
    public class ContextSqlServer : DbContext
    {
        public ContextSqlServer( DbContextOptions<ContextSqlServer> options ): base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Encuesta> Encuesta { get; set;}
    }
}
