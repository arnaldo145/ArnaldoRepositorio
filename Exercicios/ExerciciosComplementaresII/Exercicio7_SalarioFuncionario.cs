using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares_UnidadeVI
{
    class Exercicio7_SalarioFuncionario
    {
        //Escreva um programa que leia dados o tipo do funcionário (“H” = Horista ou “M” = Mensalista), 
        //o salário por hora (horistas) ou por mês (mensalistas) e, o número de horas trabalhadas 
        //(horistas) ou o valor de faltas (mensalistas), calcular o valor do salário bruto.

        static void Main7(string[] args)
        {
            string opcao = null;
            double salarioBruto = 0;
            do
            {
                Console.Clear();
                opcao = escolherOpcao().ToLower();
                switch (opcao)
                {
                    case "h":
                        Console.WriteLine("\n     HORISTA\n");
                        Console.Write("Informe o valor do salário por hora: ");
                        double salarioHora = double.Parse(Console.ReadLine());
                        Console.Write("Informe o número de horas trabalhadas: ");
                        int horasTrabalhadas = int.Parse(Console.ReadLine());
                        salarioBruto = salarioHora * horasTrabalhadas;
                        Console.WriteLine("\nSALÁRIO BRUTO: R${0:F2}", salarioBruto);
                        Console.ReadKey();
                        break;
                    case "m":
                        Console.WriteLine("\n     MENSALISTA\n");
                        Console.Write("Informe o valor do salário por mês: ");
                        double salarioMes = double.Parse(Console.ReadLine());
                        Console.Write("Informe o valor de faltas: ");
                        double faltas = double.Parse(Console.ReadLine());
                        salarioBruto = salarioMes - faltas;
                        Console.WriteLine("\nSALÁRIO BRUTO: R${0:F2}", salarioBruto);                       
                        Console.ReadKey();
                        break;
                    case "s":
                        Console.WriteLine("\nAté Logo!");
                        break;
                    default:
                        Console.WriteLine("ATENÇÃO: Opção Inválida!");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != "s");


            Console.ReadKey();

        }

        static string escolherOpcao()
        {
            Console.WriteLine("===== Cálculo de Salário ===== \nH - Horista\nM - Mensalista\nS - Sair\nInforme a categoria: ");
            string opcaoEscolhida = Console.ReadLine();
            return opcaoEscolhida;
        }
    }
}
