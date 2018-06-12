using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        //Relacion Depto
        public virtual ICollection<Depto> Depto { get; set; }

        // Relacion Comuna
        public int ComunaId { get; set; }
        public virtual Comuna Comuna { get; set; }
    }
}