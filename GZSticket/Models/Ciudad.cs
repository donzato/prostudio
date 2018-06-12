using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        //relacion comuna
        public virtual ICollection<Comuna> Comuna { get; set; }
        //relacion region
        public int RegionId { get; set; }
        public virtual Region Region { get; set; }
    }

}