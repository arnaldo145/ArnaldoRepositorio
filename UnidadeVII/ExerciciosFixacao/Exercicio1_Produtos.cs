using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExerciciosFixacao
{
    class Exercicio1_Produtos
    {
        //Faça um algoritmo para ler o código e o preço de 15 produtos, calcular e escrever: 
        //- o maior preço lido 
        //- a média aritmética dos preços dos produtos.

        static void Main1(string[] args)
        {
            double maiorPreco = 0;
            double total = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Produto {0}: ", (i + 1));
                Console.Write("Informe o código do produto: ");
                int codigo = int.Parse(Console.ReadLine());
                Console.Write("Informe o preço do produto: ");
                double preco = double.Parse(Console.ReadLine());

                total += preco;

                if (maiorPreco < preco)
                {
                    maiorPreco = preco;
                }

                Console.WriteLine("----------\n");
            }

            Console.WriteLine("\nMaior preço lido: {0} \nMédia dos preços: {1}", maiorPreco, calcularMedia(total));
            Console.ReadKey();
        }

        static double calcularMedia(double valor)
        {
            return valor / 15;
        }
    }
}
