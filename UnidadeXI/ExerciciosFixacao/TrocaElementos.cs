using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXI.ExerciciosFixacao
{
    class TrocaElementos
    {
        //Na pasta problemas, crie um arquivo chamado TrocaElementos.cs. Implemente um programa em C#.
        
        public static void Main4()
        {
            int[] valores = new int[10];
            Random gerador = new Random();
            int posicao1 = 0, posicao2 = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = gerador.Next(0, 10);
                Console.Write("{0} ", valores[i]);
            }

            Console.WriteLine("\nArray possui {0} posições!", valores.Length);            
            do
            {
               Console.Write("Informe uma posição: ");
               posicao1 = int.Parse(Console.ReadLine());
            } while (posicao1 >= valores.Length);
            
            do
            {
                Console.Write("Informe outra posição: ");
                posicao2 = int.Parse(Console.ReadLine());
            } while (posicao2 >= valores.Length);

            int auxiliar = valores[posicao1];
            valores[posicao1] = valores[posicao2];
            valores[posicao2] = auxiliar;

            Console.WriteLine("===== Troca realizada! =====");
            for (int i = 0; i < valores.Length; i++)            
                Console.Write("{0} ", valores[i]);

            Console.WriteLine("\nENTER para sair: ");
            Console.ReadKey();
        }
    }
}
