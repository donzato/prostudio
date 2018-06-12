using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class Actividad
    {
        public int Id { get; set; }
        public DateTime Finc { get; set; }
        public DateTime Fter { get; set; }
        public string Comentario { get; set; }

        //relacion ticket
        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}