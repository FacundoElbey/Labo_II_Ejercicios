using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_C01
{
    public class Jugador : Persona
    {
        //atributos
        private int partidosJugados;
        private int promedioGoles;
        private int totalGoles;

        //inicializo datos estadisticos en ctor privado
        public Jugador(string nombre, long dni) : base(nombre, dni)
        {
        }

        public Jugador(string nombre, int dni, int totalGoles, int totalPartidos) : this(nombre, dni)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;

        }

        

        //propiedades
        //solo lectural
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }


        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }
        public float PromedioGoles
        {
            get
            {
                return (float)this.totalGoles / this.PartidosJugados;
            }
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("partidos jugador: " + this.partidosJugados.ToString());
            sb.AppendLine("total goles: " + this.totalGoles.ToString());
            sb.AppendLine("Promedio goles: " + this.PromedioGoles.ToString());

            return sb.ToString();

        }

        //sobrecarga de operadores
        //dos jugadores seran iguales si tienen mismo dni
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
