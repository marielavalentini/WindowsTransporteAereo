using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelBase
{
    public abstract class TransporteAereo
    {
        public TransporteAereo(int capacidad, decimal velocidad, decimal costoPorHora)
        {
            Capacidad = capacidad;
            Velocidad = velocidad;
            CostoPorHora = costoPorHora;
        }

        public TransporteAereo() { }

        public int Capacidad { get; set; }
        public decimal Velocidad { get; set; }
        public decimal CostoPorHora { get; set; }

        public string Mostrar()
        {
            return $"Velocidad: {Velocidad} \nCosto Por Hora: {CostoPorHora} \nCapacidad: {Capacidad} ";
        }

        public abstract string Aterrizar(bool Pista);

        public abstract string Despegar(bool Pista);
        
    }
}
