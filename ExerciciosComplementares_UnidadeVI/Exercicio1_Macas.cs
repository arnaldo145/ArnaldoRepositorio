using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares_UnidadeVI
{
    class Exercicio1_Macas
    {
        //1) As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem
        //compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e
        //escreva o valor total da compra.

        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de macas que foram compradas: ");
            int qtdMacas = int.Parse(Console.ReadLine());
            double totalPagar = 0;

            if (qtdMacas < 12)
            {
                totalPagar = qtdMacas * 0.30;
            }
            else
            {
                totalPagar = qtdMacas * 0.25;
            }

            Console.WriteLine("Valor total da compra: {0}", totalPagar);
            Console.ReadKey();
        }
    }
}
