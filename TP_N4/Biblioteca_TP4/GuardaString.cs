using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_TP4
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            bool retorno = false;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

            using(StreamWriter writer = new StreamWriter(path + archivo, true))
            {
                writer.WriteLine(texto);
                retorno = true;
            }

            return retorno;
        }
    }
}
