using Microsoft.EntityFrameworkCore;
using TokerChat.Api.Models;

namespace TokerChat.Api.Infraestructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.ContactId); // Define la clave primaria
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100); // Configuración de Name
                entity.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(15); // Configuración de PhoneNumber
            });
        }
    }
}
