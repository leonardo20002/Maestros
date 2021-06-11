using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EscuelaWeb.Shared.AutoGen
{
    public partial class Academium
    {
        public Academium()
        {
            Docentes = new HashSet<Docente>();
        }

        [Key]
        [Column(TypeName = "TINYINT(4)")]
        public long Clave { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(40)")]
        public string Nombre { get; set; }
        [Column(TypeName = "SMALLINT(6)")]
        public long Plantel { get; set; }

        [ForeignKey(nameof(Plantel))]
        [InverseProperty("Academia")]
        public virtual Plantel PlantelNavigation { get; set; }
        [InverseProperty(nameof(Docente.AcademiaNavigation))]
        public virtual ICollection<Docente> Docentes { get; set; }
    }
}
