using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public class Slide
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Ruta { get; set; }
        public int orden { get; set; }
        [Timestamp]
        public byte[] fecha { get; set; }

    }
}
