using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Ciudad> Ciudad { get; set; }
    }
}