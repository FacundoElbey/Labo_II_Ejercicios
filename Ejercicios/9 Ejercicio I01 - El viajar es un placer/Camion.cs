using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_9
{
    public class Camion : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int _pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color)
        {
            _pesoCarga = pesoCarga;
        }
    }
}
