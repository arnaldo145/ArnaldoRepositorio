using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.ExerciciosComplementares
{
    class Exercicio6
    {
        //Uma locadora de vídeos tem guardada, em um vetor de 50 posições, a quantidade de filmes retirados por seus clientes durante o 
        //ano de 2004. Agora, está locadora está fazendo uma promoção e, para cada 10 filmes retirados, o cliente tem direito a uma 
        //locação grátis. Faça um algoritmo que crie um outro vetor contendo a quantidade de locações gratuitas a que cada cliente tem direito.

        static void Main6(string[] args)
        {
            Console.WriteLine(" ===== LOCADORA - PROMOÇÃO =====");
            int[] qtdFilmesLocados = new int[50];
            int[] locacoesGratuitas = new int[50];
            Random gerador = new Random();

            for (int i = 0; i < qtdFilmesLocados.Length; i++)
            {
                Console.WriteLine("\n ----- Cliente {0} -----", (i + 1));

                qtdFilmesLocados[i] = gerador.Next(0, 500);
                int count = 0, qtd = qtdFilmesLocados[i];

                while(qtd >= 10){
                    qtd -= 10;
                    count++;
                }

                locacoesGratuitas[i] = count;
                Console.WriteLine("Quantidade de filmes locados: {0} \nLocações Gratuitas: {1}\n", qtdFilmesLocados[i], locacoesGratuitas[i]);
            }
            Console.ReadKey();
        }
    }
}
