using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Inscripto
    {
        public int ID_Inscripto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? ID_Clase { get; set; } // Nullable porque permite nulos
        public int DNI { get; set; }
    }
}
