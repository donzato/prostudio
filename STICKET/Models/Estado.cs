using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        //relacion Ticket
        public virtual ICollection<Ticket> Tickets { get; set; }

        //relacion Proyecto
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}