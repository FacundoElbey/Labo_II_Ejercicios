// See https://aka.ms/new-console-template for more information

Console.BackgroundColor = ConsoleColor.Blue;
// Cambiar la letra de la consola a blanco
Console.ForegroundColor = ConsoleColor.White;
// Hacer un beep al iniciar el programa
Console.Beep(1000, 1000);

//Un comentario.
string nombre = "Facundo";
object edad = 20;
Console.WriteLine("Hello, {0} edad: {1}.", nombre, edad);

// Declarar y asignar una variable del tipo string.
string ejemplo = "Pepe";
int longitud = ejemplo.Length;

Console.WriteLine("Ingrese un numero: ");

string valor = Console.ReadLine();
bool funciono = int.TryParse(valor, out longitud);
// Calcular su longitud.
if (longitud > 5)
{
    Console.WriteLine("Es mayor a {0}.", longitud);
}
else if (longitud < 5)
{
    Console.WriteLine("Es menor a {0}.", longitud);
}
else
{
    Console.WriteLine("Es igual a {0}.", longitud);
}
// Si es mayor a 5 mostrar 'Es mayor a 5'
// De lo contrario mostrar 'Es menor a 5'
// Si es igual a 5 mostrar 'Es igual a 5'
//---------------------------------------
// Cambiar el color de fondo de la consola a azul
