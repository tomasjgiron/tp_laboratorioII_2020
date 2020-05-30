using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_TP3
{
    public class DniInvalidoException : Exception
    {
        /// <summary>
        /// Exception que se lanza cuando el DNI invalido
        /// </summary>
        public DniInvalidoException() : this("DNI invalido", null)
        {
        }

        public DniInvalidoException(string mensaje) : this(mensaje, null)
        {
        }

        public DniInvalidoException(string mensaje, Exception ex) : base(mensaje, ex)
        {
        }

        public DniInvalidoException(Exception ex) : this("DNI invalido", ex)
        {
        }
    }
}
