using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_9
{
    public class Moto : VehiculoTerrestre
    {
        public short _cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, EColores color, short cilindrada) : base(cantidadRuedas, cantidadPuertas, color)
        {
            _cilindrada = cilindrada;
        }
    }
}
