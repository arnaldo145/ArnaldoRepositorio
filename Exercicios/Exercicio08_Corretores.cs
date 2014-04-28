using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio_8
    {
        static void Main(string[] args)
        {
            //Uma empresa de vendas tem três corretores. A empresa paga ao corretor uma 
            //comissão calculada de acordo com o valor de suas vendas. Se o valor da venda 
            //de um corretor for maior que R$ 50.000.00 a comissão será de 12% do valor 
            //vendido. Se o valor da venda do corretor estiver entre R$ 30.000.00 e R$ 
            //50.000.00 (incluindo extremos) a comissão será de 9.5%. Em qualquer outro 
            //caso, a comissão será de 7%. Escreva um algoritmo que gere um relatório 
            //contendo nome, valor da venda e comissão de cada um dos corretores. O 
            //relatório deve mostrar também o total de vendas da empresa. 

            string[] nomeCorretor = new string[3];
            double[] valorVenda = new double[3];
            double[] comissaoCorretor = new double[3];
            double[] percentual = new double[3];
            double totalVendas = 0;

            Console.WriteLine("     EMPRESA DE VENDAS");
            Console.WriteLine(" ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Informe o nome do corretor: ");
                nomeCorretor[i] = Console.ReadLine();
                Console.Write("Informe o valor da venda: ");
                valorVenda[i] = double.Parse(Console.ReadLine());

                if (valorVenda[i] > 50000)
                {
                    comissaoCorretor[i] = valorVenda[i] * 0.12;
                    percentual[i] = 0.12 * 100;
                }
                if (valorVenda[i] >= 30000 && valorVenda[i] <= 50000)
                {
                    comissaoCorretor[i] = valorVenda[i] * 0.095;
                    percentual[i] = 0.095 * 100;
                }
                if (valorVenda[i] < 30000)
                {
                    comissaoCorretor[i] = valorVenda[i] * 0.07;
                    percentual[i] = 0.07 * 100;
                }

                Console.WriteLine(" ");
            }

            Console.WriteLine("      RELATÓRIO");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Corretor: " + nomeCorretor[i]);
                Console.WriteLine("Valor da venda: R$" + valorVenda[i]);
                Console.WriteLine("Percentual da comissão: " + percentual[i] + " %");
                Console.WriteLine("Comissão do corretor: R$" + comissaoCorretor[i]);
                totalVendas += valorVenda[i];
                Console.WriteLine(" ");
            }

            Console.WriteLine("Total de vendas: " + totalVendas);
            Console.ReadKey();
        }
    }
}
