using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Deportista : Humano
    {
        private EDeportista _eDeportista;
        public Deportista(string nombre, string apellido, int dni, EDeportista eDeportista) : base(nombre, apellido, dni)
        {
            _eDeportista = eDeportista;
        }

        public int GetDni()
        {
            return _dni;
        }

        public override string GetData()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Tipo de deportista: " + _eDeportista.ToString());
            sb.AppendLine(base.GetData());

            return sb.ToString();
        }

        public override string Saludar()
        {
            return GetData();
        }
    }
}
