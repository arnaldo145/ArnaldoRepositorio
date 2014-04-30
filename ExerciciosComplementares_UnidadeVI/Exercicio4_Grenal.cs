using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares_UnidadeVI
{
    class Exercicio4_Grenal
    {
        //Escreva um programa para receber números aleatórios de gols marcados pelo Grêmio e o número de gols
        //marcados pelo Inter em um GRENAL. Escrever o nome do vencedor. Mostre no final o vencedor e quando 
        //foi a partida. Caso não haja vencedor deverá ser impressa a palavra EMPATE. 
        //Lembrando que o normal de uma partida é até 5 gols para cada equipe visando o equilíbrio.

        static void Main4(string[] args)
        {
            Random gerador = new Random();
            int golsGremio = gerador.Next(0, 5);
            int golsInter = gerador.Next(0, 5);

            Console.WriteLine("===== GRENAL =====\n");
            Console.WriteLine("Grêmio: {0}", golsGremio);
            Console.WriteLine("Inter: {0}", golsInter);

            if (golsGremio > golsInter)
            {
                Console.WriteLine("\nGrêmio venceu esse jogo!");
            }

            if (golsGremio == golsInter)
            {
                Console.WriteLine("\nEmpate nesse jogo!");
            }

            if (golsGremio < golsInter)
            {
                Console.WriteLine("\nInter venceu esse jogo!");
            }

            Console.ReadKey();
        }
    }
}
