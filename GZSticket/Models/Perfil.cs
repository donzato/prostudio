using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class Perfil
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }

        //relacion cargo
        public int CargoId { get; set; }
        public virtual Cargo Cargo { get; set; }
    }
}