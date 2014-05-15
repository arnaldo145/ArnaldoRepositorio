using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosComplementares
{
    class Exercicio4
    {
        //Escreva um programa em C# que exiba no terminal a tabuada dos números de 1 a 10 de acordo com o padrão abaixo.
        public static void Main4()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(" +++++ TABUADA {0} +++++", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i, j, (i*j));
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
