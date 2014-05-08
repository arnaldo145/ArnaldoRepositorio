using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExerciciosFixacao
{
    class Exercicio3_Estoque
    {
        //Uma loja está levantando o valor total de todas as mercadorias em estoque. Escreva um algoritmo que permita a entrada das seguintes informações: 
        //a) o número total de mercadorias no estoque; 
        //b) o valor de cada mercadoria. Ao final imprimir o valor total em estoque e a média de valor das mercadorias. 

        static void Main3(string[] args)
        {
            Console.Write("Informe o número total de mercadorias no estoque: ");
            int totalMercadorias = int.Parse(Console.ReadLine());
            double countTotal = 0;
            int[] valorMercadoria = new int[totalMercadorias];

            for (int i = 0; i < valorMercadoria.Length; i++)
            {
                Console.Write("\nInforme o valor da mercadoria {0}: ", (i+1));
                double valor = double.Parse(Console.ReadLine());
                countTotal += valor;
            }

            double media = countTotal / valorMercadoria.Length;
            Console.WriteLine("\nValor total em estoque: R${0:F2} \nMédia de valor das mercadorias: R${1:F2}", countTotal, media);

            Console.ReadKey();
        }
    }
}