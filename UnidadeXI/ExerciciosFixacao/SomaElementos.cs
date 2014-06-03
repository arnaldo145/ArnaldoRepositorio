using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXI.ExerciciosFixacao
{
    class SomaElementos
    {
        //Na pasta problemas, crie um arquivo chamado SomaElementos.cs. Implemente um programa em C#.

        public static void Main2()
        {
            int[] valores = new int[10];
            Random gerador = new Random();
            int soma = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = gerador.Next(0, 10);
                Console.Write("{0} ", valores[i]);
            }

            for (int i = 0; i < valores.Length; i++)            
                soma += valores[i];

            Console.WriteLine("\nSOMA: {0}\nENTER para sair: ", soma);
            Console.ReadKey();
        }
    }
}
