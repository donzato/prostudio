using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime Finc { get; set; }
        public DateTime Fter { get; set; }
        public string Asunto { get; set; }
        public string Descripcion { get; set; }

        //relacion Estado
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }

        //relacion Actividad
        public virtual ICollection<Actividad> Actividad { get; set; }

        //relacion Depto
        public int DeptoId { get; set; }
        public virtual Depto Depto { get; set; }
    }
}