using Microsoft.EntityFrameworkCore;
using SeaCare.Models;

namespace SeaCare.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> Options) : base(Options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Reporte> Reportes { get; set; }
        public DbSet<Localizacao> Localizacoes { get; set; }
        public DbSet<Artefato> Artefatos { get; set; }

    }
}
