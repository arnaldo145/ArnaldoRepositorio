using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosComplementares
{
    class Exercicio5
    {
        //Considere um jogo no qual o jogador lança um dado 10 vezes. O jogador ganha se a soma dos
        //valores obtidos nos lançamentos for ímpar. Se o número 6 for sorteado 2 vezes o jogador 
        //perde imediatamente. O número 1 deve ser desconsiderado na somatória. Implemente um programa
        //em C# para simular a execução desse jogo
        public static void Main()
        {
            int count = 0;
            int countSeis = 0;
            bool perdeu = false;

            for (int i = 0; i < 10; i++)
            {
                int result = jogarDado();
                Console.WriteLine(result);

                if (result == 6)
                {
                    countSeis++;
                }

                if (countSeis == 2)
                {
                    perdeu = true;
                    break;
                }

                if(result != 1){
                    count += result;
                }                
            }

            if(!perdeu){
                Console.WriteLine("Você ganhou! {0} pontos", count);
            }
            else
            {
                Console.WriteLine("Você perdeu!");
            }

            Console.ReadKey();
        }

        static int jogarDado()
        {
            Random geraNum = new Random();
            return geraNum.Next(1, 6);
        }
    }
}
