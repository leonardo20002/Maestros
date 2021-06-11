using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EscuelaWeb.clases
{
    public class Tipo_usuario
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }

        public virtual Log_in Log_in { get; set; }

    }
}