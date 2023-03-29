using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex08_alg
{
    internal class Program
    {
        //8) De acordo com um valor fornecido pelo usuário, verifique se ele é múltiplo de 3,
        //ou múltiplo de 7. Apresente uma mensagem mostrando o número digitado e o resultado do teste.
        static void Main(string[] args)
        {
            Console.WriteLine("\nNeste programa você irá inserir um número e descobrir se ele é " +
                "múltiplo de 3 ou de 7.");

            Console.WriteLine("\nInsira um número: ");
            double num = Convert.ToDouble(Console.ReadLine());


            Console.Clear();
            if (num % 3 == 0 && num % 7 == 0)
            {
                Console.WriteLine("\nO número " + num + " é múltiplo de 3 e de 7");
                Console.WriteLine("\nPressione Enter para sair..");
            }
            else
            {
                if (num % 7 == 0)
                {
                    Console.WriteLine("\nO número " + num + " é múltiplo de 7");
                    Console.WriteLine("\nPressione Enter para sair..");
                }
                else
                {
                    if (num % 3 == 0)
                    {
                        Console.WriteLine("\nO número " + num + " é múltiplo de 3");
                        Console.WriteLine("\nPressione Enter para sair..");
                    }
                    else
                    {
                        Console.WriteLine("\nO número " + num + " não é múltiplo de 3 ou de 7!");
                        Console.WriteLine("\nPressione Enter para sair..");
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
