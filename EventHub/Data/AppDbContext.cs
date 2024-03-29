using EventHub.Models;
using Microsoft.EntityFrameworkCore;

namespace EventHub.Data;
    public class AppDbContext : DbContext
        {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Artistas> Artista { get; set; }
        public DbSet<CronogramaEvento> CronogramaEvento { get; set; }
        
        protected override void OnModelCreating(ModelBuilder Builder)
    {
        base.OnModelCreating(Builder);
        // Fluent API
        #region Muitos Para Muitos do BlogTag  
      
        Builder.Entity<CronogramaEvento>()
            .HasOne(bt => bt.Blog)
            .WithMany(b => b.BlogTags)
            .HasForeignKey(bt => bt.BlogId);
        Builder.Entity<BlogTag>()
            .HasOne(bt => bt.Tag)
            .WithMany(t => t.BlogTags)
            .HasForeignKey(bt => bt.BlogId);
    }
            #endregion
        }