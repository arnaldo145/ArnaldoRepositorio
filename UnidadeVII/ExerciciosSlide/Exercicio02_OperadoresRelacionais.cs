using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExerciciosSlide
{
    class Exercicio02_OperadoresRelacionais
    {
        static void Main(string[] args)
        {
            int valor = 10;

            valor += 5;
            valor -= 2;
            valor *= 2;
            valor /= 1;
            valor %= 3;
            valor++;
            valor--;

            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}
