using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones_TP3;

namespace BibliotecaArchivos_TP3
{
    public class Texto : IArchivos<string>
    {
        /// <summary>
        /// Metodo implementado desde la interfaz que guarda datos en formato texto
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    writer.Write(datos);
                    retorno = true;
                }
            }
            catch (NotSupportedException ex)
            {
                throw new ArchivosException(ex);
            }
            catch (IOException ex)
            {
                throw new ArchivosException(ex);
            }
            catch (ObjectDisposedException ex)
            {
                throw new ArchivosException(ex);
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            return retorno;
        }

        /// <summary>
        /// Metodo implementado que lee datos desde un archivo de texto
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;
            datos = string.Empty;

            try
            {
                using (StreamReader reader = new StreamReader(archivo, Encoding.UTF8))
                {
                    datos = reader.ReadToEnd();
                    retorno = true;
                }
            }
            catch (IOException ex)
            {
                throw new ArchivosException(ex);
            }
            catch (OutOfMemoryException ex)
            {
                throw new ArchivosException(ex);
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            return retorno;
        }
    }
}
