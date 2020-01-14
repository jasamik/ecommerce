using ECommerce.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public class Producto
    {
        public int ID { get; set; }
        public Categoria Categoria { get; set; }

        public Subcategoria Subcategoria { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Multimedia { get; set; }
        public decimal Precio { get; set; }
        public int ventas { get; set; }
        public int vistas { get; set; }
        [Timestamp]
        public byte[] fecha { get; set; }
    }
}
