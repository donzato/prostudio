using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class Depto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        //relacion Ticket
        public virtual ICollection<Ticket> Ticket { get; set; }
        //relacion sucursal
        public int SucursalId { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}