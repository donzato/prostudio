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

        //conexion
        private STIContext _db = new STIContext();

        //lista de estado especifica
        private List<Ticket> ObtenerEstado(int x)
        {
            return (from t in _db.Tickets
                    where t.EstadoId == x
                    select t).ToList();
        }

        //contar estado de una lista especifica
        public int EsCount(int x)
        {
            List<Ticket> t = ObtenerEstado(x);
            return (t.Count());
        }
    }
}