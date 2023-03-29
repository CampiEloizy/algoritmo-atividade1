using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07_alg
{
    internal class Program
    {
        //7) Melhore o algoritmo do exercício anterior
        //verificando se o número inserido pelo usuário é zero, par ou ímpar.
        static void Main(string[] args)
        {
            Console.WriteLine("\nNeste programa você irá inserir um número " +
                "e descobrir se ele é par, impar ou zero.");

            Console.WriteLine("\nInsira um número: ");
            double num = Convert.ToDouble(Console.ReadLine());


            Console.Clear();

            if (num == 0)
            {
                Console.WriteLine("\n>> O número inserido (" + num + ") é ZERO");
                Console.WriteLine("\nPressione Enter para sair..");
            }
            else
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("\n>> O número " + num + " é PAR");
                    Console.WriteLine("\nPressione Enter para sair..");
                }
                else
                {
                    Console.WriteLine("\n>> O número " + num + " é IMPAR");
                    Console.WriteLine("\nPressione Enter para sair..");
                }
            }


            Console.ReadKey();
        }
    }
}
