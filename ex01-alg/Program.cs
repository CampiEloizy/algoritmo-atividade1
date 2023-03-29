using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_alg
{
    internal class Program
    {
        //1) leia 4 valores, calcule a soma entre eles e apresente o resultado.
        static void Main(string[] args)
        {
            Console.WriteLine("\nNeste programa você irá digitar 4 valores e obter" +
                " o resultado da soma entre eles!");
            Console.WriteLine("\nDigite o primeiro valor: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo valor: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o terceiro valor: ");
            double n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o quarto valor: ");
            double n4 = Convert.ToDouble(Console.ReadLine());

            double soma = n1 + n2 + n3 + n4;
            double result = soma;

            Console.WriteLine("\nA soma dos números " + n1 + ", " + n2 + ", " + n3 + ", e " + n4 + " é igual à: " + result);

            Console.ReadKey();
        }
    }
}
