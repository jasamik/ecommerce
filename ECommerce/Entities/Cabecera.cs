using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    public class Cabecera
    {

        public int ID { get; set; }
        public string Ruta { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string PalabrasCables { get; set; }
        public string Portada { get; set; }
        [Timestamp]
        public byte [] fecha { get; set; }


    }
}
