using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio10
    {
        //Uma pessoa comprou quatro artigos em uma loja. Para cada artigo, tem-se 
        //nome, preço e percentual de desconto. Faça um algoritmo que imprima nome, 
        //preço e preço com desconto de cada artigo e o total a pagar.

        static void Main10(string[] args)
        {
            string[] nomeArtigo = new string[4];
            double[] preco = new double[4];
            double[] percDesconto = new double[4];
            double[] precoDesconto = new double[4];
            double totalPagar = 0;
            Console.WriteLine("     LOJAS XYZ");
            Console.WriteLine(" ");
            
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Informe o nome do artigo: ");
                nomeArtigo[i] = Console.ReadLine();
                Console.Write("Informe o preço do produto: ");
                preco[i] = double.Parse(Console.ReadLine());
                Console.Write("Informe o percentual de desconto: ");
                percDesconto[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                precoDesconto[i] = preco[i] - (preco[i] * (percDesconto[i] / 100));
                totalPagar += precoDesconto[i];
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Produto: " + nomeArtigo[i]);
                Console.WriteLine("Preço: " + preco[i]);
                Console.WriteLine("Percentual de desconto: " + percDesconto[i] + "%");
                Console.WriteLine("Preço com desconto: " + precoDesconto[i]);
                Console.WriteLine(" ");
            }
            Console.WriteLine("Total a pagar: " + totalPagar);
            Console.ReadKey();
        }
    }
}
