using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EscuelaWeb.Shared.AutoGen
{
    public partial class Proyecto2 : DbContext
    {
        public Proyecto2()
        {
        }

        public Proyecto2(DbContextOptions<Proyecto2> options)
            : base(options)
        {
        }

        public virtual DbSet<Academium> Academia { get; set; }
        public virtual DbSet<Docente> Docentes { get; set; }
        public virtual DbSet<LogIn> LogIns { get; set; }
        public virtual DbSet<Permiso> Permisos { get; set; }
        public virtual DbSet<PermisoDocente> PermisoDocentes { get; set; }
        public virtual DbSet<Plantel> Plantels { get; set; }
        public virtual DbSet<TipoPermiso> TipoPermisos { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Filename=Proyecto2.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Academium>(entity =>
            {
                entity.Property(e => e.Clave).ValueGeneratedNever();

                entity.HasOne(d => d.PlantelNavigation)
                    .WithMany(p => p.Academia)
                    .HasForeignKey(d => d.Plantel)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.Property(e => e.IdDocente).ValueGeneratedNever();

                entity.HasOne(d => d.AcademiaNavigation)
                    .WithMany(p => p.Docentes)
                    .HasForeignKey(d => d.Academia)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.OcupacionNavigation)
                    .WithMany(p => p.Docentes)
                    .HasForeignKey(d => d.Ocupacion)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LogIn>(entity =>
            {
                entity.Property(e => e.Usuario).ValueGeneratedNever();

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.LogIns)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.Property(e => e.Matricula).ValueGeneratedNever();

                entity.HasOne(d => d.IdPermisoNavigation)
                    .WithMany(p => p.Permisos)
                    .HasForeignKey(d => d.IdPermiso)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PermisoDocente>(entity =>
            {
                entity.HasOne(d => d.DocenteNavigation)
                    .WithMany(p => p.PermisoDocentes)
                    .HasForeignKey(d => d.Docente)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PermisoNavigation)
                    .WithMany(p => p.PermisoDocentes)
                    .HasForeignKey(d => d.Permiso)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Plantel>(entity =>
            {
                entity.Property(e => e.IdPlantel).ValueGeneratedNever();
            });

            modelBuilder.Entity<TipoPermiso>(entity =>
            {
                entity.Property(e => e.IdPermiso).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
