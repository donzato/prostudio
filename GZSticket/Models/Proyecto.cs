using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Finc { get; set; }
        public DateTime Fter { get; set; }

        //relacion Estado
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }

        //relacion Colaborador
        public virtual ICollection<Colaborador> Colaborador { get; set; }

        //relacion Actividades
        //public virtual ICollection<Actividad> Actividad { get; set; }
    }
}