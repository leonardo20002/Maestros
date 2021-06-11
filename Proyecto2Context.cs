using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EscuelaWeb
{
    public partial class Proyecto2Context : DbContext
    {
        public Proyecto2Context()
        {
        }

        public Proyecto2Context(DbContextOptions<Proyecto2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Academium> Academia { get; set; }
        public virtual DbSet<Docente> Docentes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Filename=Proyecto2.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Academium>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.Property(e => e.Clave)
                    .HasColumnType("TINYINT(4)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("VARCHAR(40)");

                entity.Property(e => e.Plantel).HasColumnType("SMALLINT(6)");
            });

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.HasKey(e => e.IdDocente);

                entity.ToTable("Docente");

                entity.Property(e => e.IdDocente)
                    .HasColumnType("INT (4)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID_docente");

                entity.Property(e => e.Academia).HasColumnType("TINYINT (4)");

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasColumnType("VARCHAR (40)")
                    .HasColumnName("Apellido_materno");

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasColumnType("VARCHAR (40)")
                    .HasColumnName("Apellido_paterno");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnType("VARCHAR (8)");

                entity.Property(e => e.FechaDeNacimiento)
                    .IsRequired()
                    .HasColumnType("date")
                    .HasColumnName("Fecha_de_nacimiento");

                entity.Property(e => e.FechaIngreso)
                    .IsRequired()
                    .HasColumnType("date")
                    .HasColumnName("Fecha_ingreso");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("VARCHAR (40)");

                entity.HasOne(d => d.AcademiaNavigation)
                    .WithMany(p => p.Docentes)
                    .HasForeignKey(d => d.Academia)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
