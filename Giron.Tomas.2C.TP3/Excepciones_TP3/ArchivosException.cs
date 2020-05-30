using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_TP3
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Exception que se lanza cuando hay algún problema con los archivos .txt o .xml
        /// </summary>
        /// <param name="innerException"></param>
        public ArchivosException(Exception innerException) 
            : base("El archivo no se cargó como se esperaba", innerException)
        {

        }
    }
}
