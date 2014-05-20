using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.ExerciciosComplementares
{
    class Exercicio1
    {
        //Considere um programa de computador que corrige provas de múltipla escolha. Esse programa deve armazenar em um array o gabarito de
        //uma prova. Implemente um programa em C# que gere aleatoriamente o gabarito de uma prova com 10 questões de múltipla escolha. Considere
        //que cada questão possui três alternativas numeradas de 1 a 3. Complete o código a seguir.

        static void Main1(string[] args)
        {
            Random gerador = new Random();
            int[] gabarito = new int[10];
            Console.WriteLine(" ===== GABARITO ===== ");
            for (int i = 0; i < gabarito.Length; i++)
            {
                //Intervalo do Random termina em 4 para que apareça número 3
                gabarito[i] = gerador.Next(1, 4);
                Console.WriteLine("Questão {0}: {1}", (i+1), gabarito[i]);
            }
            Console.ReadKey();
        }
    }
}
