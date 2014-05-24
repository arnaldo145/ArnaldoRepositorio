using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.ExerciciosFixacao
{
    class Array
    {
        //Na pasta funcoes-ou-metodos, crie um arquivo chamado Arrays.cs. Implemente um programa em C# definindo um
        //método que preencha um array com números inteiros aleatórios no intervalo de 0 a 99 e outro que exiba no 
        //terminal os valores armazenados em um array.

        static int[] Vetor = new int[100];
        public static void Main()
        {
            Console.WriteLine(" ===== VALORES EM ARRAYS =====\n");
            PreencherArray();
            EscreverValoresArray();
            Console.ReadKey();
            
        }

        static void PreencherArray()
        {
            Console.Write("Preenchendo array com valores: ");
            for (int i = 0; i < Vetor.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.Write(".");
                }
                Random gerador = new Random();
                Vetor[i] = i;
            }
            Console.WriteLine("\nArray com todos valores preenchidos! \n");
        }

        static void EscreverValoresArray()
        {
            Console.WriteLine("Escrever valores que estão no array: ");
            for (int i = 0; i < Vetor.Length; i++)
            {
                Console.WriteLine(Vetor[i]);
            }
            Console.WriteLine("Valores do Array foram escritos! \n");
        }
    }
}
