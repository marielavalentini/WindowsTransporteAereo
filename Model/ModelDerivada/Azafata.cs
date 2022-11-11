using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDerivada
{
    public class Azafata
    {
        public Azafata(string nombre, string apellido, Tripulacion tripulacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Tripulacion = tripulacion;
        }
        public Azafata() { }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Tripulacion Tripulacion { get; set; }
    }
}
