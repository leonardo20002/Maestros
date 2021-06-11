using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EscuelaWeb.Shared.AutoGen
{
    [Table("Permiso_Docente")]
    public partial class PermisoDocente
    {
        [Key]
        public long Numero { get; set; }
        [Column(TypeName = "INT(4)")]
        public long Permiso { get; set; }
        [Column(TypeName = "INT(4)")]
        public long Docente { get; set; }

        [ForeignKey(nameof(Docente))]
        [InverseProperty("PermisoDocentes")]
        public virtual Docente DocenteNavigation { get; set; }
        [ForeignKey(nameof(Permiso))]
        [InverseProperty("PermisoDocentes")]
        public virtual Permiso PermisoNavigation { get; set; }
    }
}
