using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EscuelaWeb.Shared.AutoGen
{
    [Table("Tipo_usuario")]
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Docentes = new HashSet<Docente>();
        }

        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column(TypeName = "VARVHAR(40)")]
        public byte[] Nombre { get; set; }

        [InverseProperty(nameof(Docente.OcupacionNavigation))]
        public virtual ICollection<Docente> Docentes { get; set; }
    }
}
