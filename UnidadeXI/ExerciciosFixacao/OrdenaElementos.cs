
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeXI.ExerciciosFixacao
{
    class OrdenaElementos
    {
        //Na pasta problemas, crie um arquivo chamado OrdenarElementos.cs. Implemente um programa em C#.
        public static void Main()
        {
            int[] valores = new int[50];
            Random geraNum = new Random();

            Console.WriteLine(" ===== DESORDENADO =====");
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = geraNum.Next(0, 30);
                Console.Write("{0} ", valores[i]);
            }

            Ordenar(valores);

            Console.WriteLine("\n ===== ORDENADO =====");
            for (int i = 0; i < valores.Length; i++)            
                Console.Write("{0} ", valores[i]);

            Console.WriteLine("\nENTER para sair: ");
            Console.ReadKey();
        }

        public static void Troca(int[] array, int i, int j)
        {
            int auxiliar = array[i];
            array[i] = array[j];
            array[j] = auxiliar;
        }

        public static int Menor(int[] array, int inicio)
        {
            int menor = inicio;

            for (int i = inicio + 1; i < array.Length; i++)
            {
                if (array[menor] > array[i])
                {
                    menor = i;
                }
            }
            return menor;
        }

        public static void Ordenar(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int menor = Menor(array, i);
                Troca(array, i, menor);
            }
        }
    }
}
