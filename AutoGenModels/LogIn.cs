using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EscuelaWeb.Shared.AutoGen
{
    [Table("Log_in")]
    public partial class LogIn
    {
        [Column("ID_usuario", TypeName = "INT (4)")]
        public long IdUsuario { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR (8)")]
        public string Contrasena { get; set; }
        [Key]
        public long Usuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        [InverseProperty(nameof(Docente.LogIns))]
        public virtual Docente IdUsuarioNavigation { get; set; }
    }
}
