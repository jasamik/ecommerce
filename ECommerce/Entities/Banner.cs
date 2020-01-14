using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    public class Banner
    {
        public int ID { get; set; }
        [Required]
        public string Ruta { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public String Imagen { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Timestamp]
        public byte[] fecha { get; set; }
    }
}
