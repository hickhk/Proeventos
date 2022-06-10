using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Model;

namespace ProEventos.Persistence.Contextos
{
    public class ProEventoContext: DbContext
    {
        public ProEventoContext(DbContextOptions<ProEventoContext> options) :base(options){  }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set; }
        public DbSet<PalestranteEvento> PalestrantesEventos { get; set; }
        public DbSet<RedeSocial> RedeSocial { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<PalestranteEvento>()
            .HasKey(PE => new {PE.EventoId, PE.PalestranteId});

            modelBuilder.Entity<Evento>()
                .HasMany(e => e.RedesSociais)
                .WithOne(rs => rs.Evento)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Palestrante>()
               .HasMany(e => e.RedesSociais)
               .WithOne(rs => rs.Palestrante)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}