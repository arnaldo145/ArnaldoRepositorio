using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar
{
    class Exercicio2
    {
        //Faça um algoritmo que leia uma coleção com 80 números decimais e encontre o menor valor, o maior valor, a média e a soma de todos os valores.
        static void Main2(string[] args)
        {
            List<double> valores = new List<double>();
            Random gerador = new Random();
            double soma = 0;

            for (int i = 0; i < 80; i++)
            {
                valores.Add(gerador.Next(0, 100) + gerador.NextDouble());
                Console.WriteLine("{0:F2} ", valores[i]);
                soma += valores[i];
            }

            valores.Sort();
            Console.WriteLine("\nMenor valor: {0:F2}\nMaior valor: {1:F2}", valores[0], valores[valores.Count - 1]);
            Console.WriteLine("Média: {0:F2} \nSoma: {1:F2}", valores.Average(), soma);
            
            Console.ReadKey();
        }
    }
}
