using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_TP3
{
    public class NacionalidadInvalidaException : Exception
    {
        /// <summary>
        /// Exception que se lanza cuando la nacionalidad no coincide con el DNI
        /// </summary>
        public NacionalidadInvalidaException() : this("La nacionalidad no concuerda" +
            " con el nro de DNI")
        {
        }

        public NacionalidadInvalidaException(string mensaje) : base(mensaje)
        {
        }
    }
}
