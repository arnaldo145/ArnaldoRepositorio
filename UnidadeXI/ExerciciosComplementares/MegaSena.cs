using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXI.ExerciciosComplementares
{
    class MegaSena
    {
        //Implemente um gerador (Aleatório) de números sorteados da mega-sena. É necessário acertar a sena, o que significa obter coincidência entre
        //seis dos números apostados e os seis números sorteados, de um total de sessenta dezenas (de 01 a 60), independentemente da ordem da aposta ou 
        //da ordem do sorteio.
        //Continuando na questão 1, o usuário agora deve informar os 6 números que ele deseja escolher. Esses 6 dados devem ser armazenados em um array
        //também, como os números premiados da questão 1. Caso o usuário escolha um número fora do intervalo do cartão da mega-sena, o software deve avisa-lo.
        //Continuando no software da mega-sena. Faça um método que Ordene do menor para o maior número. E mostre os números sorteados da seguinte forma:
        //[ 2 ] [34] [36] [45] [51] [59]
        //Continuando no software da mega-sena. Implemente um método que mostre quantos números ele acertou, comparando os arrays. Caso tenha acertado 5 
        //mostre que ele acertou a quina.

        public static void Main()
        {
            Random gerador = new Random();
            int[] valoresSorteados = new int[6];
            int[] valoresApostados = new int[6];
            Console.WriteLine(" ===== APOSTA ===== \n");
            for (int i = 0; i < valoresApostados.Length; i++)
            {
                Console.Write("Informe o {0} número da sua aposta: ", (i + 1));
                do
                {
                    valoresApostados[i] = int.Parse(Console.ReadLine());
                    if (valoresApostados[i] <= 0 || valoresApostados[i] > 60)
                        Console.Write("Valor inválido! Informe outro valor: ");
                } while (valoresApostados[i] <= 0 || valoresApostados[i] > 60);
                Console.WriteLine("--------------------------------------------");
            }

            Console.WriteLine("\n ===== SORTEIO ===== \n");
            for (int i = 0; i < valoresSorteados.Length; i++)            
                valoresSorteados[i] = gerador.Next(1, 61);
            OrdenarValores(valoresSorteados);            
            ResultadoJogada(VerificarAposta(valoresApostados, valoresSorteados));
            Console.Write("\nENTER para sair: ");
            Console.ReadKey();
        }

        public static void OrdenarValores(int[] sorteados)
        {
            for (int i = 0; i < sorteados.Length; i++)
                TrocaValores(sorteados, i, EncontrarMenor(sorteados, i));
            for (int i = 0; i < sorteados.Length; i++)            
                Console.Write("{0} ", sorteados[i]);            
        }

        public static void TrocaValores(int[] array, int i, int j)
        {
            int aux = array[i];
            array[i] = array[j];
            array[j] = aux;
        }

        public static int EncontrarMenor(int[] array, int inicio)
        {
            int menor = inicio;
            for (int i = inicio + 1; i < array.Length; i++)
            {
                if (array[menor] > array[i])
                    menor = i;
            }
            return menor;
        }

        public static int VerificarAposta(int[] apostados, int[] sorteados)
        {
            int count = 0;
            for (int i = 0; i < apostados.Length; i++)
            {
                for (int j = 0; j < sorteados.Length; j++)
                {
                    if (sorteados[j] == apostados[i])
                        count++;
                }
            }
            return count;
        }

        public static void ResultadoJogada(int numeroAcertos)
        {
            Console.WriteLine("\n \n ===== VERIFICANDO RESULTADOS ===== \n");
            switch (numeroAcertos)
            {
                case 1:
                    Console.WriteLine("Você acertou {0} número!", numeroAcertos);
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Você acertou {0} números!", numeroAcertos);
                    break;
                case 0:
                    Console.WriteLine("Nossa! Você não acertou nenhum número!");
                    break;
                case 5:
                    Console.WriteLine("Parabéns! Você acertou a quina!");
                    break;
                case 6:
                    Console.WriteLine("Que sorte! Você ganhou a mega sena!");
                    break;
            }
        }
    }
}
