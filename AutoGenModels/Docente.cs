using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EscuelaWeb.Shared.AutoGen
{
    [Table("Docente")]
    public partial class Docente
    {
        public Docente()
        {
            LogIns = new HashSet<LogIn>();
            PermisoDocentes = new HashSet<PermisoDocente>();
        }

        [Key]
        [Column("ID_docente", TypeName = "INT (4)")]
        public long IdDocente { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR (40)")]
        public string Nombre { get; set; }
        [Required]
        [Column("Apellido_paterno", TypeName = "VARCHAR (40)")]
        public string ApellidoPaterno { get; set; }
        [Required]
        [Column("Apellido_materno", TypeName = "VARCHAR (40)")]
        public string ApellidoMaterno { get; set; }
        [Required]
        [Column("Fecha_de_nacimiento", TypeName = "date")]
        public byte[] FechaDeNacimiento { get; set; }
        [Column(TypeName = "TINYINT (4)")]
        public long Academia { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR (8)")]
        public string Contrasena { get; set; }
        [Required]
        [Column("Fecha_ingreso", TypeName = "date")]
        public byte[] FechaIngreso { get; set; }
        public long Ocupacion { get; set; }

        [ForeignKey(nameof(Academia))]
        [InverseProperty(nameof(Academium.Docentes))]
        public virtual Academium AcademiaNavigation { get; set; }
        [ForeignKey(nameof(Ocupacion))]
        [InverseProperty(nameof(TipoUsuario.Docentes))]
        public virtual TipoUsuario OcupacionNavigation { get; set; }
        [InverseProperty(nameof(LogIn.IdUsuarioNavigation))]
        public virtual ICollection<LogIn> LogIns { get; set; }
        [InverseProperty(nameof(PermisoDocente.DocenteNavigation))]
        public virtual ICollection<PermisoDocente> PermisoDocentes { get; set; }
    }
}
