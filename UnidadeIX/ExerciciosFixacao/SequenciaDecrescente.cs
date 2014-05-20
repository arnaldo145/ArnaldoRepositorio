using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SequenciaDecrescente
    {
        //Na pasta arrays, crie um arquivo chamado SequenciaDecrescente.cs. Implemente um programa em C# que armazene 10 números 
        //inteiros em um array. Preencha todas as posições do array com valores sequenciais descrescentes. Ao final, exiba no
        //terminal esses valores.

        static void Main3(string[] args)
        {
            int[] valores = new int[10];

            for (int i = 9; i >=0; i--)
            {
                valores[i] = (i + 1);
                Console.WriteLine("{0}", valores[i]);
            }
            Console.ReadKey();
        }
    }
}
