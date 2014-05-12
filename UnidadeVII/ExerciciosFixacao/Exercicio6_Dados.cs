using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExerciciosFixacao
{
    class Exercicio6_Dados
    {
        //Faça um programa que simule um lançamento de dados. Lance o dado 100 vezes e armazene os resultados em um vetor.
        //Depois, mostre quantas vezes cada valor foi conseguido. Dica: use um vetor de contadores(1-6) e uma função para 
        //gerar números aleatórios, simulando os lançamentos dos dados.

        public static void Main()
        {
            int[] contadores = new int[6];
            Console.WriteLine(" ===== DADOS =====");

            for (int i = 0; i < 100; i++)
            {
                int valor = lancarDado();
                Console.WriteLine("{0}: {1}", (i + 1), valor);

                switch (valor)
                {
                    case 1:
                        contadores[0] += 1;
                        break;
                    case 2:
                        contadores[1] += 1;
                        break;
                    case 3:
                        contadores[2] += 1;
                        break;
                    case 4:
                        contadores[3] += 1;
                        break;
                    case 5:
                        contadores[4] += 1;
                        break;
                    case 6:
                        contadores[5] += 1;
                        break;
                }
            }

            Console.WriteLine("\nResultado: \n");
            for (int i = 0; i < contadores.Length; i++)
            {
                Console.WriteLine("O lado {0} aparece {1} vezes", (i + 1), contadores[i]);
            }
            Console.ReadKey();
        }

        static int lancarDado()
        {
            Random gerador = new Random();
            return gerador.Next(1, 6);
        }
    }
}
