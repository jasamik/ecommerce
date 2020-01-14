using ECommerce.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public class Compra
    {
        public int ID { get; set; }
        public Usuario Usuario { get; set; }
        public Producto Producto { get; set; }
        public string Email { get; set; }
        public string ProductoName { get; set; }
        public int cantidad { get; set; }
        public string Pago { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        [Timestamp]
        public byte[] Fecha { get; set; }


    }
}
