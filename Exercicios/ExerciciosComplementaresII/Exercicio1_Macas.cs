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

        static void Main1(string[] args)
        {
            Console.WriteLine(" ===== NOTA FISCAL ===== \n");

            Console.Write("Informe a quantidade de maçãs que foram compradas: ");
            int qtdMacas = int.Parse(Console.ReadLine());
            double totalPagar = 0;

            if (qtdMacas < 12)
            {
                Console.WriteLine("\nMaçãs: R${0:F2}", 0.30);
                totalPagar = qtdMacas * 0.30;
            }
            else
            {
                Console.WriteLine("\nMaçãs: R${0:F2}", 0.25);
                totalPagar = qtdMacas * 0.25;
            }

            Console.WriteLine("Valor total da compra: R${0:F2}", totalPagar);
            Console.ReadKey();
        }

    }
}
