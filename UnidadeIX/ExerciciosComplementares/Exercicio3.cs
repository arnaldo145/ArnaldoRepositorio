using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.ExerciciosComplementares
{
    class Exercicio3
    {
        //Escreva um algoritmo que leia um vetor de 7 elementos inteiros. Encontre e mostre o menor elemento e sua posição no vetor.

        static void Main3(string[] args)
        {
            Console.WriteLine(" ===== MENOR ELEMENTO =====\n");

            int[] valores = new int[7];
            Random gerador = new Random();

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = gerador.Next(0, 1000);
                Console.Write("{0} ", valores[i]);
            }

            int menorValor = valores[0];

            for (int i = 0; i < valores.Length; i++)
            {
                if (menorValor > valores[i])
                {
                    menorValor = valores[i];
                }
            }

            Console.WriteLine("\n \nMenor valor: {0}", menorValor);
            Console.ReadKey();
        }
    }
}
