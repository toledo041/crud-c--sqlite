using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCSharp.Modelo
{
    public class Empleado
    {
        public int id_empleado { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; } 
        public string telefono { get; set; }
    }
}
