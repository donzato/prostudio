using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        //relacion Perfil
        public virtual ICollection<Perfil> Perfil { get; set; }
    }
}