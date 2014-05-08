using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExerciciosFixacao
{
    class Exercicio2_Prefeitura
    {
//        A prefeitura de uma cidade deseja fazer uma pesquisa entre seus habitantes. Faça um algoritmos para coletar
//        dados sobre o salário e número de filhos de cada habitante e após as leituras, escrever: 
//        a) Média de salário da população 
//        b) Média do número de filhos 
//        c) Maior salário dos habitantes 
//        d) Percentual de pessoas com salário menor que R$ 150,00 
//        Obs.: O final da leituras dos dados se dará com a entrada de um “salário negativo”

        static void Main(string[] args)
        {            
            double maiorSalario = 0;

            int countHabitantes = 0;
            int countSalarioBaixo = 0;
            int countFilhos = 0;
            double countSalario = 0;

            bool terminado = false;

            do
            {
                Console.Write("Informe o salário do habitante: ");
                double salario = double.Parse(Console.ReadLine());

                terminado = (salario < 0 ? true : false);

                if (terminado == false)
                {
                    Console.Write("Informe a quantidade de filhos: ");
                    int qtdFilhos = int.Parse(Console.ReadLine());

                    countFilhos += qtdFilhos;
                    countSalario += salario;
                    countHabitantes++;

                    if (salario < 150)
                    {
                        countSalarioBaixo += 1;
                    }

                    if (maiorSalario < salario)
                    {
                        maiorSalario = salario;
                    }

                    Console.WriteLine("----------------------------\n");
                }
            } while (terminado != true);

            Console.WriteLine("\nMédia de salário dos habitantes: {0:F2} \nMédia de número de filhos: {1}", calcularMediaSalario(countHabitantes, countSalario), calcularMediaFilhos(countFilhos, countHabitantes));
            Console.WriteLine("Maior salário: R${0} \nPercentual de habitantes que recebem menos de R$150: {1}%", maiorSalario, calcularPercentual(countHabitantes, countSalarioBaixo));
            Console.WriteLine("Número de habitantes: {0}", countHabitantes);
            Console.ReadKey();            
        }

        static double calcularMediaFilhos(int filhos, int habitantes){
            return filhos / habitantes;
        }

        static double calcularMediaSalario(int habitantes, double salario)
        {
            return salario / habitantes;
        }

        static double calcularPercentual(int totalHabitantes, int habitantesSalarioBaixo){
            return (100 * habitantesSalarioBaixo) / totalHabitantes;
        }
    }
}
