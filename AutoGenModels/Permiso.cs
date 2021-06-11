using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EscuelaWeb.Shared.AutoGen
{
    [Table("Permiso")]
    public partial class Permiso
    {
        public Permiso()
        {
            PermisoDocentes = new HashSet<PermisoDocente>();
        }

        [Key]
        [Column(TypeName = "INT(4)")]
        public long Matricula { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(40)")]
        public string Nombre { get; set; }
        [Required]
        [Column("Apellido_paterno", TypeName = "VARCHAR(40)")]
        public string ApellidoPaterno { get; set; }
        [Required]
        [Column("Apellido_materno", TypeName = "VARCHAR(40)")]
        public string ApellidoMaterno { get; set; }
        [Required]
        [Column("Fecha_permiso", TypeName = "date")]
        public byte[] FechaPermiso { get; set; }
        [Required]
        [Column("Fecha_inicio", TypeName = "date")]
        public byte[] FechaInicio { get; set; }
        [Required]
        [Column("Fecha_termino", TypeName = "date")]
        public byte[] FechaTermino { get; set; }
        [Column(TypeName = "time")]
        public byte[] Horario { get; set; }
        [Required]
        [Column(TypeName = "BINARY")]
        public byte[] Estado { get; set; }
        [Column("Id_permiso", TypeName = "TINYINT(4)")]
        public long IdPermiso { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string Motivo { get; set; }
        [Column("Cantidad_permisos", TypeName = "SMALLINT(4)")]
        public long CantidadPermisos { get; set; }

        [ForeignKey(nameof(IdPermiso))]
        [InverseProperty(nameof(TipoPermiso.Permisos))]
        public virtual TipoPermiso IdPermisoNavigation { get; set; }
        [InverseProperty(nameof(PermisoDocente.PermisoNavigation))]
        public virtual ICollection<PermisoDocente> PermisoDocentes { get; set; }
    }
}
