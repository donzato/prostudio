using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class Provincia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //region
        public int RegionId { get; set; }
        public virtual Region Region{ get; set; }
    }
}