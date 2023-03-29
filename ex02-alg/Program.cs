using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02_alg
{
    internal class Program
    {
        //2) leia 3 valores, calcule a média aritmética entre eles e apresente o resultado.
        static void Main(string[] args)
        {
            Console.WriteLine("\nNeste programa você irá inserir 3 valores" +
                " e obter a média entre eles");

            Console.WriteLine("\nDigite o primeiro valor: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo valor: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o terceiro valor: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;
            double result = media;

            Console.Clear();
            Console.WriteLine("\nA média dos números " + n1 + ", " + n2 + " e " + n3 + " é igual à: " + result);

            Console.ReadKey();
        }
    }
}
