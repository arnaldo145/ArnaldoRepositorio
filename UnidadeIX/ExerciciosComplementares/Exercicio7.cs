using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.ExerciciosComplementares
{
    class Exercicio7
    {
         //Faça um algoritmo que leia dois vetores (A e B) de 50 posições de números inteiros. O algoritmo deve, então, subtrair o 
        //primeiro elemento de A do último de B, acumulando o valor, subtrair o segundo elemento de A do penúltimo de B, acumulando
        //o valor, e assim por diante. Mostre o resultado da soma final.

        static void Main7(string[] args)
        {
            Console.WriteLine(" ===== SOMA DE VALORES ===== \n");

            Random gerador = new Random();
            int[] A = new int[50];
            int[] B = new int[50];

            for (int i = 0; i < 50; i++)
            {
                A[i] = gerador.Next(0, 200);
                B[i] = gerador.Next(0, 200);
            }

            int bSize = 49;
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("{0} - {1} = {2}", A[i], B[bSize], A[i] - B[bSize]);
                count += (A[i] - B[bSize]);
                bSize--;
            }

            Console.WriteLine("\nSoma Final: {0}", count);

            Console.ReadKey();
        }
    }
}
