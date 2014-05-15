using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosComplementares
{
    class Exercicio2
    {
        //Crie um programa em C# que exiba o seguinte padrão no terminal.

        public static void Main2()
        {
            string text = "**********";
            int count = 0;
            int i = 0;

            while (i < 2)
            {
                for (int j = 0; j < 5; j++)
                {
                    espaco(count);
                    Console.WriteLine("{0}", text);
                    count++;
                }
                count = 0;
                Console.WriteLine(" ");
                i++;
            }
            Console.ReadKey();
        }

        static void espaco(int valor)
        {
            for (int i = 0; i < valor; i++)
            {
                Console.Write(" ");
            }
        }
    }
}
