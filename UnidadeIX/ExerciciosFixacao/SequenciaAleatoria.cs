using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SequenciaAleatoria
    {
        //Na pasta arrays, crie um arquivo chamado SequenciaAleatoria.cs. Implemente um programa em C# que armazene 10 números inteiros aleatórios
        //em um array. Ao final, exiba no terminal esses valores.

        static void Main5(string[] args)
        {
            Random gerador = new Random();
            int[] valores = new int[10]{gerador.Next(0, 1000), gerador.Next(0, 1000), gerador.Next(0, 1000), 
                gerador.Next(0, 1000), gerador.Next(0, 1000), gerador.Next(0, 1000), gerador.Next(0, 1000), gerador.Next(0, 1000), 
                gerador.Next(0, 1000), gerador.Next(0, 1000)};

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Valor na posição {0}: {1}", i, valores[i]);
            }

            Console.ReadKey();
        }
    }
}
