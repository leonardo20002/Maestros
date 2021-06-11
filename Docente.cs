using System;
using System.Collections.Generic;

#nullable disable

namespace EscuelaWeb
{
    public partial class Docente
    {
        public long IdDocente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public byte[] FechaDeNacimiento { get; set; }
        public long Academia { get; set; }
        public string Contrasena { get; set; }
        public byte[] FechaIngreso { get; set; }
        public long Ocupacion { get; set; }

        public virtual Academium AcademiaNavigation { get; set; }
    }
}
