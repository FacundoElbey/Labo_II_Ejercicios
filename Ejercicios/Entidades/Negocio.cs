using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Negocio
    {
        private PuestoAtencion _caja;
        private Queue<Cliente> _clientes;
        private string _nombre;

        public Queue<Cliente> Clientes
        {
            get { return _clientes; }
            set { _clientes = value; }
        }
        private Negocio()
        {
            _clientes = new Queue<Cliente>();
            _caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            _nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;

            foreach(Cliente item in n.Clientes)
            {
                if(c == item)
                {
                    retorno = true; 
                }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if(n != c)
            {
                n._clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }
    }
}
