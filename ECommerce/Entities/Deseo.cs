using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public class Deseo
    {
        public int ID { get; set; }
        public Usuario Usuario { get; set; }
        public Producto Producto { get; set; }
        [Timestamp]
        public byte[] fecha { get; set; }

    }
}
