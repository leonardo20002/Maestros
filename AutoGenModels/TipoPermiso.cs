using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EscuelaWeb.Shared.AutoGen
{
    [Table("Tipo_permiso")]
    public partial class TipoPermiso
    {
        public TipoPermiso()
        {
            Permisos = new HashSet<Permiso>();
        }

        [Key]
        [Column("ID_permiso", TypeName = "TINYINT(4)")]
        public long IdPermiso { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(40)")]
        public string Nombre { get; set; }

        [InverseProperty(nameof(Permiso.IdPermisoNavigation))]
        public virtual ICollection<Permiso> Permisos { get; set; }
    }
}
