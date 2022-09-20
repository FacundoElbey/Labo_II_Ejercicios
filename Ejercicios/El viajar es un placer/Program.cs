using Entidades_9;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Camion camioncito = new Camion(8, 2, EColores.Azul, 8, 5000);
        Console.WriteLine("Camion camioncito \nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga {4}", camioncito._cantidadRuedas, camioncito._cantidadPuertas, camioncito._color, camioncito.cantidadMarchas, camioncito._pesoCarga);
        Console.WriteLine("--------------");
        Automovil autito = new Automovil(4, 5, EColores.Blanco, 5, 3);
        Console.WriteLine("Automovil autito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", autito._cantidadRuedas, autito._cantidadPuertas, autito._color, autito._cantidadMarchas, autito._cantidadPasajeros);
        Console.WriteLine("-----------");
        Moto motito = new Moto(2, 0, EColores.Rojo, 1000);
        Console.WriteLine("Moto motito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", motito._cantidadRuedas, motito._cantidadPuertas, motito._color, motito._cilindrada);
    }
}
