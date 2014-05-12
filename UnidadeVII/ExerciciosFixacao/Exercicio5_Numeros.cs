using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExerciciosFixacao
{
    class Exercicio5_Numeros
    {
         //Faça o programa que apresenta a seguinte saída, perguntando ao usuário o número máximo. Este número deve ser sempre ímpar.

        public static void Main()
        {
            int valor = 0;

            do
            {
                Console.Write("Informe o número máximo: ");
                valor = int.Parse(Console.ReadLine());

                if (valor % 2 == 0)
                {
                    Console.WriteLine("\nATENÇÃO: O valor informado deve ser impar!\n");
                }
            } while (valor % 2 == 0);

            int b = (valor - 1) / 2;

            for (int i = 0; i <= (valor / 2) + 1; i++)
            {
                for (int j = i + 1; j <= valor - i; j++)
                {
                    Console.Write("{0} ", j);
                }

               Console.Write("\n");

                for (int j = 0; j < (i + 1) * 2; j++)
                    Console.Write(" ");
            }
            
            Console.ReadKey();
        }
    }
}
