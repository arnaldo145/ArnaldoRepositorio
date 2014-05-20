using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TabelaAleatoria
    {
        static void Main7(string[] args)
        {
            int[,] valores = new int[5, 5];
            Random gerador = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    valores[i, j] = gerador.Next(10, 99);
                    Console.Write("{0} ", valores[i, j]);
                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
