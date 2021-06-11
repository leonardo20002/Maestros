using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EscuelaWeb.Shared.AutoGen
{
    [Table("Plantel")]
    public partial class Plantel
    {
        public Plantel()
        {
            Academia = new HashSet<Academium>();
        }

        [Key]
        [Column("ID_plantel", TypeName = "SMALLINT(6)")]
        public long IdPlantel { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(40)")]
        public string Nombre { get; set; }

        [InverseProperty(nameof(Academium.PlantelNavigation))]
        public virtual ICollection<Academium> Academia { get; set; }
    }
}
