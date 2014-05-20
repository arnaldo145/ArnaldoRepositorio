using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.ExerciciosComplementares
{
    class Exercicio4
    {
        //Escreva um algoritmo que leia um vetor inteiro de 12 posições e crie um segundo vetor, substituindo os valores nulos por 1. Mostre os 2 vetores.

        static void Main4(string[] args)
        {
            int[] vetor1 = new int[12];
            int[] vetor2 = new int[12];
            Random gerador = new Random();

            Console.WriteLine(" ===== COMPARAÇÃO DE VETORES =====");

            for (int i = 0; i < vetor1.Length; i++)
            {
                int val = gerador.Next(0, 10);
                vetor1[i] = val;

                if (val == 0)
                    vetor2[i] = 1;
                else
                    vetor2[i] = val;
            }

            Console.Write("\nVetor 1: ");
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write("{0} ", vetor1[i]);
            }

            Console.Write("\nVetor 2: ");
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write("{0} ", vetor2[i]);
            }

            Console.ReadKey();
        }
    }
}
