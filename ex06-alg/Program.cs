using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_alg
{
    internal class Program
    {
        //6) Verifique se um número fornecido pelo usuário é par ou impar.
        //Para isto, apresente uma mensagem mostrando o número digitado e o resultado do teste.
        static void Main(string[] args)
        {
            Console.WriteLine("\nNeste programa você irá inserir um número e descobrir " +
                "se ele é par ou impar.");

            Console.WriteLine("\nInsira um número: ");
            double num = Convert.ToDouble(Console.ReadLine());


            Console.Clear();
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


            Console.ReadKey();  
        }
    }
}
