using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main1(string[] args)
        {
            //Faça um algoritmo que leia os valores A, B e C. Mostre uma mensagem que 
            //informe se a soma de A com B é menor, maior ou igual a C. 

            Console.Write("Informe valor para A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Informe valor para B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Informe valor para C: ");
            int c = int.Parse(Console.ReadLine());

            int soma = a + b;

            if (soma > c)
            {
                Console.WriteLine("Valor da soma de A e B é maior do que C!");
            }

            if (soma == c)
            {
                Console.WriteLine("Valor da soma de A e B é igual a C!");
            }

            if (soma < c)
            {
                Console.WriteLine("Valor da soma de A e B é menor do que C!");
            }

            Console.ReadKey();
        }
    }
}
