using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.ExerciciosFixacao
{
    class ConsumoDeCombustivel
    {
        //Na pasta funcoes-ou-metodos, crie um arquivo chamado ConsumoDeCombustivel.cs. Implemente um programa em C# definindo 
        //um método que realize o cálculo do consumo de combustível de um veículo.

        public static void Main1()
        {
            Console.WriteLine(" ===== CÁLCULO DO CONSUMO DE COMBUSTIVEL ===== ");

            Console.Write("Informe a distância percorrida: ");
            double distanciaPercorrida = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de combustivel: ");
            double qtdCombustivel = double.Parse(Console.ReadLine());
            Console.WriteLine("\nConsumo médio: {0:F1} KM por Litro", CalcularConsumo(distanciaPercorrida, qtdCombustivel));
            Console.ReadKey();
        }

        static double CalcularConsumo(double distancia, double combustivel)
        {
            return distancia / combustivel;
        }
    }
}
