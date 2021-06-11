using Microsoft.EntityFrameworkCore;
namespace EscuelaWeb.clases
{
    public class Proyecto2 : DbContext
    {
        public DbSet<Log_in> Log_ins { get; set; }
        public DbSet<Tipo_usuario> Tipo_usuarios { get; set; }
        public DbSet<Tipo_permiso> Tipo_permisos { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine( System.Environment.CurrentDirectory, "Proyecto2.db");
            optionsBuilder.UseSqlite($"Filename={path}");   
        }
    }
}