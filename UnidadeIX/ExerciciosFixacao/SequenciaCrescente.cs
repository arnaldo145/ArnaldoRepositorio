using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SequenciaCrescente
    {
        //Na pasta arrays, crie um arquivo chamado SequenciaCrescente.cs. Implemente um programa em C# que armazene 10 números
        //inteiros em um array. Preencha todas as posições do array com valores sequenciais. Ao final, exiba no terminal esses valores.

        static void Main2(string[] args)
        {
            int[] valores = new int[10];

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = (i + 1);
                Console.WriteLine("Valores na posição {0}: {1}", i, valores[i]);
            }
            Console.ReadKey();
        }
    }
}
