using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXI.ExerciciosFixacao
{
    class MediaElementos
    {
        //Na pasta problemas, crie um arquivo chamado MediaElementos.cs. Implemente um programa em C#.

        public static void Main3()
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

            double media = soma / valores.Length;
            Console.WriteLine("\nMédia dos valores: {0} \nENTER para sair: ", media);
            Console.ReadKey();
        }
    }
}
