using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.ExerciciosComplementares
{
    class Exercicio8
    {
        //Escreva um algoritmo que leia um vetor de 13 elementos inteiros, que é o Gabarito de um teste da loteria esportiva, contendo os
        //valores 1(coluna 1), 2 (coluna 2) e 3 (coluna do meio). Leia, a seguir, para cada apostador, o número do seu cartão e um vetor 
        //de Respostas de 13 posições. Verifique para cada apostador os números de acertos, comparando o vetor de Gabarito com o vetor de 
        //Respostas. Escreva o número do apostador e o número de acertos. Se o apostador tiver 13 acertos, mostrar a mensagem "Ganhador".

        static void Main(string[] args)
        {
            int[] gabarito = new int[13];
            Random gerador = new Random();

            Console.WriteLine(" ===== GABARITO ===== ");
            for (int i = 0; i < gabarito.Length; i++)
            {
                gabarito[i] = gerador.Next(1, 4);
                Console.WriteLine("Jogada {0}: Coluna {1}", (i + 1), gabarito[i]);
            }

            int[] numeroCartao = new int[15];

            for (int i = 0; i < numeroCartao.Length; i++)
            {
                Console.WriteLine("\n ===== JOGADOR {0} =====", (i + 1));
                numeroCartao[i] = gerador.Next(0,100);
                Console.WriteLine("Número do cartão: {0}", numeroCartao[i]);

                int[] respostas = new int[13];
                int countAcertos = 0;

                for (int j = 0; j < respostas.Length; j++)
                {
                    respostas[j] = gerador.Next(1, 4);

                    if(respostas[j] == 1)
                    {
                        Console.WriteLine("Jogada {0}: X   -   -", (j + 1), respostas[j]);
                    }

                    if (respostas[j] == 2)
                    {
                        Console.WriteLine("Jogada {0}: -   -   X", (j + 1), respostas[j]);
                    }

                    if (respostas[j] == 3)
                    {
                        Console.WriteLine("Jogada {0}: -   X   -", (j + 1), respostas[j]);
                    }

                    if (respostas[j] == gabarito[j])                    
                        countAcertos++;                    
                }
                Console.WriteLine("Acertos: {0}", countAcertos);

                if (countAcertos == 13)
                    Console.WriteLine("GANHADOR!");
                else
                    Console.WriteLine("NÃO GANHOU!");
            }
            Console.ReadKey();
        }
    }
}
