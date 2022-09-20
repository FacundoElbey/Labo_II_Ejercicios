using Entidades_C01;

namespace _9_ejercios_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectorTecnico t1 = new DirectorTecnico("t1", Convert.ToDateTime("12/11/2001"));
            DirectorTecnico t2 = new DirectorTecnico("t2", Convert.ToDateTime("20/3/2001"));
            Equipo equipo = new Equipo(2, "utn");
            Jugador j1 = new Jugador("nom1", 123, 5, 20);
            Jugador j2 = new Jugador("nom2", 485, 3, 5);
            Jugador j3 = new Jugador("nom3", 123, 7, 3);
            Jugador j4 = new Jugador("nom4", 789, 3, 5);

            if (equipo + j1)
                Console.WriteLine(j1.MostrarDatos());

            if (equipo + j2)
                Console.WriteLine(j2.MostrarDatos());

            if (equipo + j3)
                Console.WriteLine(j3.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO " + j3.MostrarDatos());

            if (equipo + j4)
                Console.WriteLine(j4.MostrarDatos());

            else
                Console.WriteLine("NO SE AGREGO " + j4.MostrarDatos());

            if (t1 == t2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }


            if (t1 == t1)
            {
                Console.WriteLine("Son iguales");
                Console.WriteLine(t1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No son iguales");
            }
        }
    }
}
