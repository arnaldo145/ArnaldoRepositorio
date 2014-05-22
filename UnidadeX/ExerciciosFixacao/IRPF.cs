using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.ExerciciosFixacao
{
    class IRPF
    {
        //Na pasta funcoes-ou-metodos, crie um arquivo chamado IRPF.cs. Implemente um programa em C# definindo um método que
        //realize o cálculo do imposto de renda pessoa física.

        public static void Main()
        {
            Console.WriteLine(" ===== IMPOSTO DE RENDA =====\n");
            Console.Write("Informe o rendimento (R$): ");
            double rendimento = double.Parse(Console.ReadLine());
            Console.Write("Informe os descontos do INSS: ");
            double inss = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da pensão alimenticia: ");
            double pensaoAlimenticia = double.Parse(Console.ReadLine());
            Console.Write("Informe os gastos com dependentes: ");
            double dependentes = double.Parse(Console.ReadLine());

            Console.WriteLine("\n ===== RESULTADO ===== \n \nValor Base: R${0:F2}", CalcularValorBase(rendimento, inss, pensaoAlimenticia, dependentes));
            Console.WriteLine("Imposto de Renda: R${0:F2}", CalcularImpostoRenda(CalcularValorBase(rendimento, inss, pensaoAlimenticia, dependentes)));
            Console.ReadKey();
        }

        static double CalcularValorBase(double valorRendimento, double valorINSS, double valorPensao, double valorDependentes)
        {
            valorRendimento -= valorINSS;
            valorRendimento -= valorPensao;
            valorRendimento -= valorDependentes;
            return valorRendimento;
        }

        static double CalcularImpostoRenda(double valorBase)
        {
            double valor = 0;

            if(valorBase < 1787.77){
                valor = 0;
            }

            if (valorBase >= 1787.77 && valorBase < 2679.29)
            {
                valor = valorBase * (7.5/100);
                valor -= 134.08;
            }

            if (valorBase >= 2679.29 && valorBase < 3572.43)
            {
                valor = valorBase * (15/100);
                valor -= 335.03;
            }

            if (valorBase > 3572.43 && valorBase < 4463.81)
            {
                valor = valorBase * (22.5/100);
                valor -= 602.96;
            }

            if (valorBase >= 4463.81)
            {
                valor = valorBase * (27.5 / 100);
                valor -= 826.15;
            }
            return valor;
        }
    }
}
