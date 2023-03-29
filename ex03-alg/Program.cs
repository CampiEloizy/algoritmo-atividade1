using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_alg
{
    internal class Program
    {
        //3) Uma loja de produtos eletrônicos com vendas regulares opta por contratar uma equipe
        //para a organização de um sistema de gerenciamento de vendas.
        //Seu desafio será elaborar um algoritmo que, a partir de dados fornecidos pelo usuário,
        //calcule o valor da venda de um produto, exibindo uma saída em vídeo contendo o código do produto,
        //o nome, a quantidade comprada, o valor unitário e o valor total.

        static void Main(string[] args)
        {
            Console.WriteLine("\nNeste programa você irá obter o valor final de uma compra!");

            Console.WriteLine("\nInsira o nome do produto: ");
            string prod = Console.ReadLine();
            Console.WriteLine("\nInsira o código do produto: ");
            string cod = Console.ReadLine();
            Console.WriteLine("\nInsira o valor do produto: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInforme o total de unidades do produto a ser comprado: ");
            int quant = Convert.ToInt32(Console.ReadLine());

            double valorTotal = quant * valor;

            Console.Clear();
            Console.WriteLine("\n>> Código do Produto: " + cod);
            Console.WriteLine("\n>> Nome: " + prod);
            Console.WriteLine("\n>> Valor Unitário: " + valor);
            Console.WriteLine("\n>> Unidades compradas: " + quant);
            Console.WriteLine("\n>> Valor Total da Compra: " + valorTotal);
            Console.WriteLine("\nPressione Enter para sair..");

            Console.ReadKey();
        }
    }
}
