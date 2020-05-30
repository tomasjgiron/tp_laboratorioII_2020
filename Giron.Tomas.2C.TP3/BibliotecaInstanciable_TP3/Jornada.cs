using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static BibliotecaInstanciable_TP3.Universidad;
using EntidadesAbstractas;
using BibliotecaArchivos_TP3;

namespace BibliotecaInstanciable_TP3
{
#pragma warning disable CS0660,CS0661
    public class Jornada
    {
        #region Atributos
        private List<Alumno> alumnos;
        private EClases clase;
        private Profesor instructor;
        #endregion

        #region Constructores
        /// <summary>
        /// Constuctor privado de jornada que instancia la lista de alumnos
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor que reutiliza el anterior e instancia la clase y el profesor
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(EClases clase, Profesor instructor) : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que hace publica la lista
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        /// <summary>
        /// Propiedad que hace publica la clase
        /// </summary>
        public EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        /// <summary>
        /// Propiedad que hace publico al instructor
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que lee un archivo en formato texto
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            Texto fileTxt = new Texto();
            fileTxt.Leer(AppDomain.CurrentDomain.BaseDirectory + "Jornada.txt", out string auxJornada);
            return auxJornada;

        }

        /// <summary>
        /// Metodo que guarda los datos de Jornada en un archivo de texto
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            bool retorno = false;
            Texto fileTxt = new Texto();
            if (fileTxt.Guardar(AppDomain.CurrentDomain.BaseDirectory
                + "Jornada.txt", jornada.ToString()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Sobreescritura del metodo ToString que muestra los datos de Jornada
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder cadenaJornada = new StringBuilder();
            cadenaJornada.AppendFormat($"CLASE DE {this.Clase.ToString()} POR {this.Instructor.ToString()}");
            cadenaJornada.AppendFormat("\r\n\r\nALUMNOS: \r\n");
            foreach (Alumno student in this.Alumnos)
            {
                cadenaJornada.AppendFormat($"{student.ToString()}\r\n");
            }

            return cadenaJornada.ToString();
        }

        /// <summary>
        /// Operador que iguala una jornada y un alumno
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            return a == j.Clase;
        }

        /// <summary>
        /// Operador que distingue una jornada y un alumno
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Operador que agrega un alumno a la lista de jornadas
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            bool flag = true;
            if (j == a)
            {
                foreach (Alumno student in j.Alumnos)
                {
                    if (student == a)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    j.Alumnos.Add(a);
                }
            }
            return j;
        }
        #endregion
    }
}
