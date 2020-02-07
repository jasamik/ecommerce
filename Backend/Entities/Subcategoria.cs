using ECommerce.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public class Subcategoria
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Categoria Categoria { get; set; }
        public int estado { get; set; }
        [Timestamp]
        public byte[] fecha { get; set; }
    }
}
