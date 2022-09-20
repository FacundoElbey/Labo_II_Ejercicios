using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Tecnico : Deportista
    {

        public Tecnico(string nombre, string apellido, int dni, EDeportista eDeportista) : base(nombre, apellido, dni, eDeportista)
        {

        }

        public override string GetData()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("---------------------");
            sb.Append(base.GetData());
            sb.Append("---------------------");
            return sb.ToString();
        }
    }
}
