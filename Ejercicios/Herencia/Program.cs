// See https://aka.ms/new-console-template for more information

using Herencia;

//No se pueden instanciar clases abstractas

Deportista deportista = new Deportista("Facundo ", "Elbey ", 43896662, EDeportista.Futbolista);

Programador programador = new Programador("Antonio ", "Aguirre ", 42859421, 800);

Console.WriteLine(deportista.GetData());

Console.WriteLine(programador.GetData());