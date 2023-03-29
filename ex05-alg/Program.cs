using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_alg
{
    internal class Program
    {
        //5. As lojas de um shopping center estão concedendo 10% de desconto no preço de qualquer produto.
        //Faça um algoritmo que, a partir do valor fornecido, calcule e exiba o preço atual
        //e o preço com o desconto.
        static void Main(string[] args)
        {
            Console.WriteLine("\nNeste programa você irá obter o preço final de um produto do 'Shopping Center' " +
                "com 10% de desconto.");

            Console.WriteLine("\nInsira o nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("\nInsira o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            double desconto = preco - (preco * 0.1);

            Console.Clear();
            Console.WriteLine("\n>> Nome do produto: " + nome);
            Console.WriteLine("\n>> Preço Atual: " + preco);
            Console.WriteLine("\n>> Preço com desconto: " + desconto);
            Console.WriteLine("\nPressione Enter para sair..");



            Console.ReadKey();
        }
    }
}
