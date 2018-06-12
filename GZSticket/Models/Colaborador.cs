using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public int Ntareas { get; set; }

        public int EspecialidadId { get; set; }
        public virtual Especialidad Especialidad { get; set; }

        //relacion Proyecto
        public int ProyectoId { get; set; }
        public virtual Proyecto Proyecto { get; set; }
    }
}