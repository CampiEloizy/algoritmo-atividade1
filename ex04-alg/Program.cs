using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_alg
{
    internal class Program
    {
        //4) Uma empresa concederá um reajuste salarial de 8,75% no próximo mês.
        //Sua missão é elaborar um algoritmo que, a partir de dados inseridos pelo usuário,
        //calcule o salario reajustado de um funcionário, exibindo como resultado, seu nome,
        //o valor de seu salário atual e o valor do salário reajustado.
        static void Main(string[] args)
        {
            Console.WriteLine("\nNeste programa você irá obter o salário reajustado " +
                "dos funcionários de uma empresa.");

            Console.WriteLine("\nInsira seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("\nInsira seu salário atual: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double salarioReajustado = salario + (salario * (8.75/100));


            Console.Clear();
            Console.WriteLine("\n>> Nome do Funcionário: " + nome);
            Console.WriteLine("\n>> Salário Atual: " + salario);
            Console.WriteLine("\n>> Salário Reajustado: " + salarioReajustado);
            Console.WriteLine("\nPressione Enter para sair..");

            Console.ReadKey();
        }
    }
}
