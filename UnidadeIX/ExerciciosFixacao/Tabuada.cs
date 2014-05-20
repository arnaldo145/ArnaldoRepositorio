using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Tabuada
    {

        //Na pasta arrays, crie um arquivo chamado Tabuada.cs. Implemente um programa em C# que armazene números inteiros em um array
        //de arrays. Ao final, exiba no terminal esses valores.

        static void Main(string[] args)
        {
            int[,] valores = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    valores[i, j] = i * j;
                    Console.WriteLine("{0} X {1} = {2}", i, j, valores[i,j]);
                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
