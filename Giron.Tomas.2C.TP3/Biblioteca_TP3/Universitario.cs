using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
#pragma warning disable CS0659, CS0661
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Constructores
        /// <summary>
        /// Constructor por defecto de Universitario
        /// </summary>
        public Universitario()
        {
        }

        /// <summary>
        /// Constructor que llama a la base e instancia el legajo
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobreeescritura del metodo Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj is null))
            {
                if (this.GetType() == obj.GetType())
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Metodo que muestra los datos de Universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder cadenaUniversitario = new StringBuilder();
            cadenaUniversitario.AppendFormat($"{base.ToString()}LEGAJO NUMERO: {this.legajo}\r\n");

            return cadenaUniversitario.ToString();
        }

        /// <summary>
        /// Metodo abstracto
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Operador que compara dos universitarios
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario u1, Universitario u2)
        {
            return u1.Equals(u2) && u1.legajo == u2.legajo || u1.DNI == u2.DNI;
        }

        /// <summary>
        /// Operador que distingue dos universitarios
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario u1, Universitario u2)
        {
            return !(u1 == u2);
        }
        #endregion
    }
}
