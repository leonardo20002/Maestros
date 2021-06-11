using System;
using System.Collections.Generic;

#nullable disable

namespace EscuelaWeb
{
    public partial class Academium
    {
        public Academium()
        {
            Docentes = new HashSet<Docente>();
        }

        public long Clave { get; set; }
        public string Nombre { get; set; }
        public long Plantel { get; set; }

        public virtual ICollection<Docente> Docentes { get; set; }
    }
}
