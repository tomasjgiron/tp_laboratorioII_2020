using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static BibliotecaInstanciable_TP3.Universidad;
using EntidadesAbstractas;

namespace BibliotecaInstanciable_TP3
{
#pragma warning disable CS0660, CS0661
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<EClases> claseDelDia;
        private static Random random;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor estatico de Profesor que instancia el random
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }

        /// <summary>
        /// Constructor por defecto de Profesor
        /// </summary>
        public Profesor() : base()
        {
        }

        /// <summary>
        /// Constructor que llama a la base e instancia la cola y la llena con dos clases random
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseDelDia = new Queue<EClases>();
            _randomClases();
            _randomClases();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que guarda los datos de Profesor en una cadena
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder cadenaProfesor = new StringBuilder();
            cadenaProfesor.AppendFormat($"{base.MostrarDatos()}");
            cadenaProfesor.AppendFormat($"{this.ParticiparEnClase()}");

            return cadenaProfesor.ToString();
        }

        /// <summary>
        /// Sobreescritura del metodo ToString que muestra los datos del Profesor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Metodo que asigna dos clases random a la cola
        /// </summary>
        private void _randomClases()
        {
            int auxRandom = random.Next(0, 4);
            Thread.Sleep(500);
            this.claseDelDia.Enqueue((EClases)auxRandom);
        }

        /// <summary>
        /// Metodo que muestra las clases del Profesor
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder cadenaClase = new StringBuilder();
            cadenaClase.AppendFormat($"CLASES DEL DÍA: ");
            foreach (EClases clase in this.claseDelDia)
            {
                cadenaClase.AppendFormat($"\r\n{clase}");
            }

            return cadenaClase.ToString();
        }

        /// <summary>
        /// Operador que iguala un profesor y una clase
        /// </summary>
        /// <param name="p"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor p, EClases clase)
        {
            return p.claseDelDia.Contains(clase);
        }

        /// <summary>
        /// Operador que distingue un profesor y una clase
        /// </summary>
        /// <param name="p"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor p, EClases clase)
        {
            return !(p == clase);
        }
        #endregion
    }
}
