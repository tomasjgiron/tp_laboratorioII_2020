using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Opera entre dos objetos de tipo Numero y el operador recibido
        /// </summary>
        /// <param name="num1"> Primer numero </param>
        /// <param name="num2"> Segundo numero </param>
        /// <param name="operador"> operador </param>
        /// <returns> retorna el resultado de la operacion </returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;

            if(!(num1 is null) && !(num2 is null))
            {
                switch (ValidarOperador(operador))
                {
                    case "+":
                        {
                            retorno = num1 + num2;
                            break;
                        }
                    case "-":
                        {
                            retorno = num1 - num2;
                            break;
                        }
                    case "*":
                        {
                            retorno = num1 * num2;
                            break;
                        }
                    case "/":
                        {
                            retorno = num1 / num2;
                            break;
                        }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Valida el operador recibido
        /// </summary>
        /// <param name="operador"> recibe un operador string </param>
        /// <returns> retorna el operador recibido, el cual por defecto sera +</returns>
        private static string ValidarOperador(string operador)
        { 
            string retorno = "+";

            if(operador == "-")
            {
                retorno = "-";
            }
            else if(operador == "/")
            {
                retorno = "/";
            }
            else if(operador == "*")
            {
                retorno = "*";
            }

            return retorno;
        }
    }
}
