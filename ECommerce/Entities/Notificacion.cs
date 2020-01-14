using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public class Notificacion
    {
        public int ID { get; set; }
        public string UsuarioNuevo { get; set; }
        public string VentaNueva { get; set; }
        public string VisitaNueva { get; set; }

    }
}
