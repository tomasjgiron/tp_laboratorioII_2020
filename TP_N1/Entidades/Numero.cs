using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Propiedad que setea el valor de numero y usa el metodo de validacion
        /// </summary>
        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor con double
        /// </summary>
        /// <param name="numero"> recibe un double y lo asigna al numero</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor con string
        /// </summary>
        /// <param name="strNumero"> recibe un string y lo parsea a double</param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// Metodo que valida el string que se recibe 
        /// </summary>
        /// <param name="strNumero"> string </param>
        /// <returns> retorna el doble si logra validarlo y parsearlo correctamente </returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;

            if(!(strNumero is null))
            {
                double.TryParse(strNumero, out retorno);
            }
            return retorno;
        }

        /// <summary>
        /// Metodo que convierte el string binario recibido en un string decimal
        /// </summary>
        /// <param name="binario"> string que representa un numero binario </param>
        /// <returns> retorna el numero decimal en string </returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";
            int aux;
            string auxString;

            int.TryParse(binario, out aux);
            if(aux < 0)
            {
                Math.Abs(aux);
            }

            if(aux == 0)
            {
                retorno = "0";
            }

            else
            {
                auxString = aux.ToString();
                char[] numero = auxString.ToCharArray();
                Array.Reverse(numero);
                int dec = 0;
                int i;

                for (i = 0; i < numero.Length; i++)
                {
                    if (numero[i] == '1')
                    {
                        dec += (int)Math.Pow(2, i);
                    }
                }

                retorno = Convert.ToString(dec);
            }
            return retorno;
        }

        /// <summary>
        /// Metodo que convierte un numero double decimal en binario
        /// </summary>
        /// <param name="numero"> double recibido </param>
        /// <returns> retorna una cadena string como numero binario </returns>
        public string DecimalBinario(double numero)
        {
            string retorno = "Valor invalido";
            int aux;
            string auxStr;
            string strBinario = "";

            auxStr = numero.ToString();

            int.TryParse(auxStr, out aux);
            if (aux < 0)
            {
                Math.Abs(aux);
            }

            if (aux == 0)
            {
                retorno = "0";
            }
            else
            {
                while (aux > 1)
                {
                    if (aux % 2 == 0)
                    {
                        strBinario += "0";
                    }
                    else
                    {
                        strBinario += "1";
                    }
                    aux /= 2;
                }

                auxStr = aux.ToString();
                strBinario += auxStr;
                char[] arrayBinario = strBinario.ToCharArray();
                Array.Reverse(arrayBinario);
                retorno = new string(arrayBinario);
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que utiliza al anterior para devolver el numero binario
        /// </summary>
        /// <param name="numero"> string recibido </param>
        /// <returns> retorna el numero binario como string </returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido";
            double aux;

            if(double.TryParse(numero, out aux))
            {
                retorno = DecimalBinario(aux);
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga que permite sumar dos objetos de tipo Numero
        /// </summary>
        /// <param name="n1"> primer Numero </param>
        /// <param name="n2"> segundo Numero </param>
        /// <returns> retorna el resultado de la operacion </returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga que permite restar dos objetos de tipo Numero
        /// </summary>
        /// <param name="n1"> primer Numero </param>
        /// <param name="n2"> segundo Numero </param>
        /// <returns> retorna el resultado de la operacion </returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga que permite multiplicar dos objetos de tipo Numero
        /// </summary>
        /// <param name="n1"> primer Numero </param>
        /// <param name="n2"> segundo Numero </param>
        /// <returns> retorna el resultado de la operacion </returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga que permite dividir dos objetos de tipo Numero, previa validacion
        /// </summary>
        /// <param name="n1"> primer Numero </param>
        /// <param name="n2"> segundo Numero </param>
        /// <returns> retorna el resultado de la operacion </returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = double.MinValue;
            if(n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }
            return retorno;
        }
    }
}
