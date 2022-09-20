using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_C01
{
    public class Persona
    {
        private long _dni;
        private string _nombre;

        public long Dni { get => _dni; set => _dni = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public Persona(string nombre)
        {
            _nombre = nombre;
        }

        public Persona(string nombre, long dni) : this(nombre)
        {
            _dni = dni;
            _nombre = nombre;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(_nombre);
            sb.Append(" ");
            sb.Append(_dni);

            return sb.ToString();
        }
    }
}
