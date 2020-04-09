using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PruebaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numBinario = new Numero();
            Numero numDecimal = new Numero();

            Console.WriteLine(numBinario.BinarioDecimal("1010101"));
            Console.WriteLine(numDecimal.DecimalBinario("800"));

            Console.Write("Presione cualquier tecla");

            Console.ReadKey();

        }
    }
}
