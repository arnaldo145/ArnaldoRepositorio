using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExerciciosSlide
{
    class Exercicio01_OperadoresAritmeticos
    {
        static void Main(string[] args)
        {
            int soma = 3 + 2;
            int subtracao = 10 - 5;
            int multiplicacao = 2 * 5;
            int divisao = 10 / 2;
            int modulo = 15 % 5;
            double divCast = (double)5 / 2;
            Console.WriteLine("Soma: {0} \nSubtração: {1} \nMultiplicação: {2} \nDivisão: {3} \nMódulo: {4}", soma, subtracao, multiplicacao, divisao, modulo);
            Console.ReadKey();
        }
    }
}
