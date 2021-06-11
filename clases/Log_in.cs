using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EscuelaWeb.clases
{
    public class Log_in
    {
        
        public int ID_usuario { get; set; }
        public string Contrasena { get; set; }
        public int Usuario { get; set; }

        public virtual ICollection<Tipo_usuario> Tipo_usuarios { get; set; }
        public Log_in()
        {
            this.Tipo_usuarios = new HashSet<Tipo_usuario>();
        }
    }
}