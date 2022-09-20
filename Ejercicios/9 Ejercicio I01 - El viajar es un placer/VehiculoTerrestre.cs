using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_9
{
    public class VehiculoTerrestre
    {
        public short _cantidadRuedas;
        public short _cantidadPuertas;
        public EColores _color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColores color)
        {
            _cantidadRuedas = cantidadRuedas;
            _cantidadPuertas = cantidadPuertas;
            _color = color;
        }
    }
}
