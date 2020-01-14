using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public class Visita
    {
        public int ID { get; set; }
        public string Pais { get; set; }
        public int Cantidad { get; set; }
        [Timestamp]
        public byte[] fecha { get; set; }
    }
}
