using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }

        private static int _numeroActual;
        private Puesto _puesto;

        public int NumeroActual
        {
            get { return _numeroActual; }
        }

        static PuestoAtencion()
        {
            _numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            if (puesto == Puesto.Caja1)
            {
                _puesto = Puesto.Caja1;
            }
            else if (puesto == Puesto.Caja2)
            {
                _puesto = Puesto.Caja2;
            }
        }

        public bool Atender(Cliente cli)
        {
            bool retorno = false;
            if(cli != null)
            {
                Thread.Sleep(3000);
                _numeroActual++;
                retorno = true;
            }
            return retorno;
        }
    }
}
