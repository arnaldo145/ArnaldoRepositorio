using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SequenciaImpar
    {
        //Na pasta arrays, crie um arquivo chamado SequenciaImpar.cs. Implemente um programa em C# que armazene 10 números inteiros ímpares em
        //um array. Ao final, exiba no terminal esses valores.

        static void Main4(string[] args)
        {
            int[] valores = new int[10];
            Random valor = new Random();
            int numAleatorio = 0;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    numAleatorio = valor.Next(0, 100);
                } while (numAleatorio % 2 == 0);

                valores[i] = numAleatorio;
                Console.WriteLine(valores[i]);
            }
            Console.ReadKey();
        }
    }
}
