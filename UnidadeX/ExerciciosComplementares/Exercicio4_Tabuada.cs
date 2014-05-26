using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.ExerciciosComplementares
{
    class Exercicio4_Tabuada
    {
        //Faça um método chamado tabuada que passa por parâmetro o número da tabuada. Por exemplo se passar 4 por parâmetro
        //ela deve retornar a tabuada completa do 4.

        public static void Main()
        {
            Console.WriteLine(" ===== TABUADA =====\n");
            Console.Write("Informe o valor: ");
            int valor = int.Parse(Console.ReadLine());
            MontarTabuada(valor);
            Console.ReadKey();
        }

        static void MontarTabuada(int numero)
        {
            Console.WriteLine("\nMontando a tabuada de {0}: \n", numero);
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine("{0} X {1} = {2}", numero, i, resultado);
            }
        }
    }
}
