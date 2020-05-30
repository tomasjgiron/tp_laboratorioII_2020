using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones_TP3;
using EntidadesAbstractas;
using BibliotecaArchivos_TP3;

namespace BibliotecaInstanciable_TP3
{
#pragma warning disable CS0660,CS0661
    public class Universidad
    {
        #region Enumerados
        /// <summary>
        /// Enumerado de clases
        /// </summary>
        public enum EClases { Programacion, Laboratorio, Legislacion, SPD }
        #endregion

        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de Universidad que instancia las listas de alumnos, jornadas y profesores
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que hace publica la lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        /// <summary>
        /// Propiedad que hace publica la lista de jornadas
        /// </summary>
        public List<Jornada> Jornada
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }

        /// <summary>
        /// Propiedad que hace publica la lista de profesores
        /// </summary>
        public List<Profesor> Profesores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }

        /// <summary>
        /// Indexador de jornada
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Jornada this[int index]
        {
            get
            {
                return this.jornada[index];
            }
            set
            {
                this.jornada.Add(value);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que lee un archivo de formato xml
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            Xml<Universidad> fileXml = new Xml<Universidad>();
            fileXml.Leer(AppDomain.CurrentDomain.BaseDirectory + "Universidad.xml", out Universidad uni);
            return uni;
        }

        /// <summary>
        /// Metodo que guarda todos los datos de la unviersidad en un archivo xml
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            bool retorno = false;
            Xml<Universidad> fileXml = new Xml<Universidad>();
            if(fileXml.Guardar(AppDomain.CurrentDomain.BaseDirectory 
                + "Universidad.xml", uni))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Metodo que guarda los datos de Universidad en una cadena
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder cadenaUniversidad = new StringBuilder();
            cadenaUniversidad.AppendFormat("JORNADA:\r\n");
            foreach (Jornada workday in uni.jornada)
            {
                cadenaUniversidad.AppendFormat(workday.ToString());
            }
            return cadenaUniversidad.ToString();
        }

        /// <summary>
        /// Sobreescritura del metodo ToString que muestra los datos de Universidad
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        /// <summary>
        /// Metodo que iguala una universidad y un alumno
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad u, Alumno a)
        {
            bool retorno = false;
            if (!(u is null) && !(a is null))
            {
                foreach (Alumno student in u.Alumnos)
                {
                    if (student == a)
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que distingue una universidad y un alumno
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad u, Alumno a)
        {
            return !(u == a);
        }

        /// <summary>
        /// Metodo que iguala una universidad y un profesor
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad u, Profesor p)
        {
            bool retorno = false;
            if (!(u is null) && !(p is null))
            {
                foreach (Profesor teacher in u.Profesores)
                {
                    if (teacher == p)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Metodo que distingue una universidad y un profesor
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad u, Profesor p)
        {
            return !(u == p);
        }

        /// <summary>
        /// Metodo que iguala una universidad y una clase
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            Profesor retorno = null;
            if (!(u is null))
            {
                foreach (Profesor teacher in u.Profesores)
                {
                    if (teacher == clase)
                    {
                        retorno = teacher;
                        break;
                    }
                }
                if (retorno is null)
                {
                    throw new SinProfesorException();
                }
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que disntigue una universidad y una clase
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            Profesor retorno = null;
            if (!(u is null))
            {
                foreach (Profesor teacher in u.Profesores)
                {
                    if (teacher != clase)
                    {
                        retorno = teacher;
                        break;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Metodo que suma una clase a la lista de jornadas
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, EClases clase)
        {
            Universidad retorno = null;
            if (!(u is null))
            {
                Profesor prof = (u == clase);
                Jornada workday = new Jornada(clase, prof);
                foreach (Alumno student in u.Alumnos)
                {
                    if (student == clase)
                    {
                        workday.Alumnos.Add(student);
                    }
                }
                u.Jornada.Add(workday);
                retorno = u;
            }
            return retorno;
        }

        /// <summary>
        /// Metodo que suma un alumno a la lista de alumnos
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (!(u is null) && !(a is null))
            {
                if (u != a)
                {
                    u.Alumnos.Add(a);
                }
                else
                {
                    throw new AlumnoRepetidoException();
                }
            }
            return u;
        }

        /// <summary>
        /// Metodo que suma un profesor a la lista de profesores
        /// </summary>
        /// <param name="u"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Profesor p)
        {
            if (!(u is null) && !(p is null))
            {
                if (u != p)
                {
                    u.Profesores.Add(p);
                }
            }
            return u;
        }
        #endregion
    }
}
