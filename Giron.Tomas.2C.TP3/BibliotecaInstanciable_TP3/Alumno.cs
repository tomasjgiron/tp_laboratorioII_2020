using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaInstanciable_TP3.Universidad;
using EntidadesAbstractas;

namespace BibliotecaInstanciable_TP3
{
#pragma warning disable CS0660, CS0661
    public sealed class Alumno : Universitario
    {
        #region Atributos
        private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region Enumerados
        /// <summary>
        /// Enumerado de estados de cuenta
        /// </summary>
        public enum EEstadoCuenta { AlDia, Deudor, Becado }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de Alumno
        /// </summary>
        public Alumno()
        {
        }

        /// <summary>
        /// Constructor que llama a la base e instancia claseQueToma
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor que reutiliza el anterior e instancia estadoCuenta
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que guarda los datos de Alumno en una cadena
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder cadenaAlumno = new StringBuilder();
            cadenaAlumno.AppendFormat($"{base.MostrarDatos()}");
            cadenaAlumno.AppendFormat($"\r\nESTADO DE CUENTA: {this.estadoCuenta}\r\n" +
                $"{this.ParticiparEnClase()}");

            return cadenaAlumno.ToString();
        }

        /// <summary>
        /// Sobreescritura del metodo ToString que muestra los datos del Alumno
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Metodo que muestra las clase que toma el Alumno
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder cadenaParticipacion = new StringBuilder();
            cadenaParticipacion.AppendFormat($"TOMA CLASE DE: {this.claseQueToma}\r\n");
            cadenaParticipacion.AppendFormat($"<---------------------------SEPARADOR--------------------------->\r\n");

            return cadenaParticipacion.ToString();
        }

        /// <summary>
        /// Operador que iguala un alumno y una clase
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, EClases clase)
        {
            return a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor;

        }

        /// <summary>
        /// Metodo que distingue un alumno y una clase
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, EClases clase)
        {
            return a.claseQueToma != clase;
        }
#endregion
    }
}
