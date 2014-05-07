using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExerciciosSlide
{
    class Exercicio02_OperadoresRelacionais
    {
        static void Main2(string[] args)
        {
            int valor = 10;

            //Operadores Atribuição
            valor += 5;
            Console.WriteLine("{0}", valor);

            valor -= 2;
            Console.WriteLine("{0}", valor);

            valor *= 2;
            Console.WriteLine("{0}", valor);

            valor /= 1;
            Console.WriteLine("{0}", valor);

            valor %= 3;
            Console.WriteLine("{0}", valor);

            valor++;
            Console.WriteLine("{0}", valor);

            valor--;
            Console.WriteLine("{0}", valor);

            bool status = true;
            int num = 5;

            //Operadores Relacionais
            status = (num > 10);
            Console.WriteLine("{0} > 10: {1}", num, status);

            status = (num < 10);
            Console.WriteLine("{0} < 10: {1}", num, status);

            status = (num >= 10);
            Console.WriteLine("{0} >= 10: {1}", num, status);

            status = (num <= 10);
            Console.WriteLine("{0} <= 10: {1}", num, status);

            status = (num == 10);
            Console.WriteLine("{0} == 10: {1}", num, status);

            status = (num != 10);
            Console.WriteLine("{0} != 10: {1}", num, status);

            //Operadores Lógicos
            status = num > 5 && num < 10;
            Console.WriteLine("{0}", status);

            status = num > 5 & num < 10;
            Console.WriteLine("{0}", status);

            status = num > 5 | num < 10;
            Console.WriteLine("{0}", status);

            status = num > 5 || num < 10;
            Console.WriteLine("{0}", status);

            Console.ReadKey();
        }
    }
}
