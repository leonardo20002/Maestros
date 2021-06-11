using Microsoft.EntityFrameworkCore;

namespace EscuelaWeb
{
    public class maestros : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "maestros.db");
            optionsBuilder.UseSqlite($"Filename = {path}");
        }

    }
}