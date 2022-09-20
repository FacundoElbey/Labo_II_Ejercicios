using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_C01
{
    public class DirectorTecnico : Persona
    {
        public DateTime _fechaNacimiento;

        private DirectorTecnico(string nombre) : base(nombre)
        {
        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            _fechaNacimiento = fechaNacimiento;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(_fechaNacimiento);
            sb.AppendLine(Nombre);

            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            bool retorno = false;
            if((dt1._fechaNacimiento == dt2._fechaNacimiento) && (dt1.Nombre == dt2.Nombre))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
