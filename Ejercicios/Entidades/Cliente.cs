using System.Xml.Linq;

namespace Entidades
{
    public class Cliente
    {
        private string _nombre;
        private int _numero;

        #region Properties
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Numero
        {
            get { return _numero; }
        }
        #endregion

        public Cliente(int numero)
        {
            _numero = numero;
            _nombre = "";
        }

        public Cliente(int numero, string nombre): this(numero)
        {
            _nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Numero == c2.Numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
       
    }
}