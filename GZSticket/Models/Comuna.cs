using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class Comuna
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        //Relacion sucursal
        public virtual ICollection<Sucursal> Sucursal { get; set; }

        //relacion Provincia
        public int ProvinciaId { get; set; }
        public virtual Provincia Provincia { get; set; }    
    }
}