using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_TP3
{
    public class AlumnoRepetidoException : Exception
    {
        /// <summary>
        /// Exception que se lanza cuando se quiere cargar un alumno que ya esté en la lista
        /// </summary>
        public AlumnoRepetidoException() : base("El alumno ya figura en la lista")
        {

        }
    }
}
