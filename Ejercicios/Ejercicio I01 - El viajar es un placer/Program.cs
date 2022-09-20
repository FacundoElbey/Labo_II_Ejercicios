using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_9;

namespace Ejercicio_I01___El_viajar_es_un_placer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion camioncito = new Camion(8, 2, EColores.Azul, 8, 5000);
            Console.WriteLine("Camion camioncito \nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga {4}", camioncito.cantRuedas, camioncito.cantPuertas, camioncito.color, camioncito.cantMarchas, camioncito.pesoDeCarga);
            Console.WriteLine("--------------");
            Automovil autito = new Automovil(4, 5, EColores.Blanco, 5, 3);
            Console.WriteLine("Automovil autito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", autito.cantRuedas, autito.cantPuertas, autito.color, autito.cantMarchas, autito.cantPasajeros);
            Console.WriteLine("-----------");
            Moto motito = new Moto(2, 0, EColores.Rojo, 1000);
            Console.WriteLine("Moto motito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", motito.cantRuedas, motito.cantPuertas, motito.color, motito.cilindradas);
        }
    }
}
