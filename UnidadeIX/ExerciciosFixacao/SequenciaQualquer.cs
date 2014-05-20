using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SequenciaQualquer
    {
        //Na pasta arrays, crie um arquivo chamado SequenciaQualquer.cs. Implemente um programa em C# que armazene 10 números inteiros
        //em um array. Todas as posições do array devem ser preenchidas e o valor armazenado fica à sua escolha. Após preencher o array,
        //exiba os seus valores no terminal.

        static void Main1(string[] args)
        {
            Random gerador = new Random();
            int[] valores = new int[10];

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = gerador.Next(0, 1000);
                Console.WriteLine("Valor na posição {0}: {1}", i, valores[i]);
            }
            Console.ReadKey();
        }
    }
}
