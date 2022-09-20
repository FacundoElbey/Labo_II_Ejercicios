namespace Entidades_9
{
    public class Automovil : VehiculoTerrestre
    {
        public short _cantidadMarchas;
        public int _cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
        {
            _cantidadMarchas = cantidadMarchas;
            _cantidadPasajeros = cantidadPasajeros;
        }
    }
}