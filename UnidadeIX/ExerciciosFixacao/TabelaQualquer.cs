using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TabelaQualquer
    {
        //Na pasta arrays, crie um arquivo chamado TabelaQualquer.cs. Implemente um programa em C# que armazene números inteiros em uma array de arrays.
        //Ao final, exiba no terminal esses valores.

        static void Main7(string[] args)
        {
            int[,] valores = new int[3, 2];
            for (int i = 0; i < 3; i++)
			{
                for (int j = 0; j < 2; j++)
			    {
                    Console.Write("Informe um valor: ");
                    valores[i,j] = int.Parse(Console.ReadLine());
			    }
			}
            Console.WriteLine(" ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", valores[i, j]);
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
