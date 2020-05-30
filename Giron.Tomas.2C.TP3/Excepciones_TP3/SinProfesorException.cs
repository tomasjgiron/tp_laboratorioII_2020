using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_TP3
{
    public class SinProfesorException : Exception
    {
        /// <summary>
        /// Exception que se lanza cuando no hay un profesor para dar una Clase de la Universidad
        /// </summary>
        public SinProfesorException() : base("La clase no tiene profesor")
        {

        }
    }
}
