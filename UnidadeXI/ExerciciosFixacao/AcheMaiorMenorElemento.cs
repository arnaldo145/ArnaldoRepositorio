using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXI.ExerciciosFixacao
{
    class AcheMaiorMenorElemento
    {
        //Na pasta problemas, crie um arquivo chamado AcharMaiorMenorElemento.cs. Implemente um programa em C#.

        public static void Main1()
        {
            int[] valores = new int[10];
            Random gerador = new Random();
            int posicaoMenor = 0;
            int posicaoMaior = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = gerador.Next(0,100);
                Console.Write("{0} ", valores[i]);
            }
           
            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[posicaoMaior] < valores[i])
                    posicaoMaior = i;
            }            

            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[posicaoMenor] > valores[i])
                    posicaoMenor = i;
            }

            Console.WriteLine("\nMaior valor: {0} \nMenor valor: {0}\n", valores[posicaoMaior], valores[posicaoMenor]);
            Console.WriteLine("ENTER para sair: ");
            Console.ReadKey();
        }
    }
}
