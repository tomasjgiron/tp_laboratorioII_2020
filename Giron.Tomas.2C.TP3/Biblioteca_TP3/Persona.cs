using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones_TP3;

namespace EntidadesAbstractas
{
#pragma warning disable CS0660, CS0661
    public abstract class Persona
    {
        #region Atributos y Propiedades
        private string nombre;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = ValidarNombreApellido(value); }
        }

        private string apellido;

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = ValidarNombreApellido(value); }
        }

        private int dni;

        public int DNI
        {
            get { return this.dni; }
            set
            {

                if (ValidarDni(this.nacionalidad, value) > 0)
                {
                    dni = value;
                }
            }
        }

        public string StringToDNI
        {
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }

        private ENacionalidad nacionalidad;

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
        #endregion

        #region Enumerados
        /// <summary>
        /// Enumerado de nacionalidad
        /// </summary>
        public enum ENacionalidad { Argentino, Extranjero }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de Persona
        /// </summary>
        public Persona()
        {
        }

        /// <summary>
        /// Constructor de persona que inicializa nombre, apellido y nacionalidad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor que reutiliza el anterior e instancia dni como int
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.dni = dni;
        }

        /// <summary>
        /// Constructor que reutiliza el anterior e instancia dni como string
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobreeescritura del metodo ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder cadenaPersona = new StringBuilder();
            cadenaPersona.AppendFormat($"NOMBRE COMPLETO: {this.Apellido}, {this.Nombre}\r\n" +
                $"NACIONALIDAD: {this.Nacionalidad}\r\n\r\n");

            return cadenaPersona.ToString();
        }

        /// <summary>
        /// Metodo que valida la nacionalidad y el rango numerico de los dni
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int retorno = 0;
            if (nacionalidad == ENacionalidad.Argentino && dato >= 1 && dato <= 89999999)
            {
                retorno = dato;
            }
            else if (nacionalidad == ENacionalidad.Extranjero && dato >= 90000000 && dato <= 99999999)
            {
                retorno = dato;
            }
            else
            {
                throw new NacionalidadInvalidaException();
            }
            return retorno;
        }

        /// <summary>
        /// Metodo que valida la cantidad de numeros del dni y llama al anterior
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int auxDni;
            int retorno = 0;
            if (!(dato is null) && dato.Length <= 8 && int.TryParse(dato, out auxDni))
            {
                retorno = ValidarDni(nacionalidad, auxDni);
            }
            else
            {
                throw new DniInvalidoException();
            }
            return retorno;
        }

        /// <summary>
        /// Metodo que valida nombres y apellido
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            bool retorno = true;
            string auxRetorno = string.Empty;

            if (!(dato is null))
            {
                foreach (char letter in dato)
                {
                    if (!(char.IsLetter(letter)))
                    {
                        retorno = false;
                    }
                }
                if (retorno)
                {
                    auxRetorno = dato;
                }
            }
            return auxRetorno;
        }
        #endregion
    }
}
