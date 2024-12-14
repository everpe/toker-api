using Microsoft.EntityFrameworkCore;

namespace TokerChat.Api.Infraestructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSets: Cada uno representa una tabla
        //public DbSet<Product> Products { get; set; }

        // Opcionalmente puedes sobreescribir OnModelCreating si necesitas configuraciones adicionales
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuración adicional de entidades, índices, etc.
        }
    }
}
