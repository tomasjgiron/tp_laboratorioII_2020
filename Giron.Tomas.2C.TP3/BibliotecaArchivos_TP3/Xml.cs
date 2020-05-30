using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones_TP3;

namespace BibliotecaArchivos_TP3
{
    public class Xml<T> : IArchivos<T>
    {
        /// <summary>
        /// Metodo implementado desde la interfaz que guarda archivos en formato xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;


            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(T));
                using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    serializador.Serialize(writer, datos);
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            return retorno;
        }

        /// <summary>
        /// Metodo implementado desde la interfaz que lee datos desde un archivo xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;


            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(string));
                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    datos = (T)serializador.Deserialize(reader);
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }

            return retorno;
        }
    }
}
