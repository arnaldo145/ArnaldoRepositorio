using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.ExerciciosFixacao
{
    class JuroComposto
    {
        //Na pasta funcoes-ou-metodos, crie um arquivo chamado JurosComposto.cs. Implemente um programa em C# definindo um método
        //que realize o cálculo do montante obtido com a aplicação de juros compostos.

        public static void Main2()
        {
            Console.WriteLine(" ===== CÁLCULO DE JURO COMPOSTOS =====\n");
            Console.Write("Informe o capital inicial: ");
            double capitalInicial = double.Parse(Console.ReadLine());
            Console.Write("Informe a taxa de juros (%): ");
            double taxaJuros = double.Parse(Console.ReadLine());
            Console.Write("Informe o tempo: ");
            double tempo = double.Parse(Console.ReadLine());
            Console.WriteLine("\nMontante: R${0:F2}", CalcularJuroComposto(capitalInicial, taxaJuros, tempo));
            Console.ReadKey();
        }

        static double CalcularJuroComposto(double capital, double juro, double tempo)
        {
            return capital * Math.Pow((1 + (juro / 100)), tempo);
        }
    }
}
