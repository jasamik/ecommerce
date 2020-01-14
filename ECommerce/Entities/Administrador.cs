using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    public class Administrador
    {
        public int ID { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Foto { get; set; }
        [Required]
        public String Password { get; set; }
        [Required]
        public string Perfil { get; set; }
        [Required]
        public bool estado { get; set; }
        [Timestamp]
        public byte[] fecha { get; set; }
    }
}
