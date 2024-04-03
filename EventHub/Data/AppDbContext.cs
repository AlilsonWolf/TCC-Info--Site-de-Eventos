using EventHub.Models;
using Microsoft.EntityFrameworkCore;

namespace EventHub.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Artistas> Artista { get; set; }
        public DbSet<CronogramaEvento> CronogramaEvento { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Fluent API
            #region Muitos Para Muitos do CronogramaEvento e Evento
            builder.Entity<CronogramaEvento>()
                .HasOne(ce => ce.Evento)
                .WithMany(e => e.CronogramaEvento)
                .HasForeignKey(ce => ce.EventoId);
                
            builder.Entity<CronogramaEvento>()
                .HasOne(ce => ce.Artistas)
                .WithMany()
                .HasForeignKey(ce => ce.ArtistaId);
            #endregion
        }
    }
}
