
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
        public static void Main5()
        {
            int[] valores = new int[50];
            Random geraNum = new Random();
            Console.WriteLine(" ===== DESORDENADO =====");

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = geraNum.Next(0, 300);
                Console.Write("{0} ", valores[i]);                
            }

            Console.WriteLine(" ");
            OrdenarCrescente(valores);
            Console.WriteLine("\n ===== ORDENADO =====");
            for (int i = 0; i < valores.Length; i++)            
                Console.Write("{0} ", valores[i]);
            Console.WriteLine("\n \nENTER para sair: ");
            Console.ReadKey();
        }

        public static void TrocaValores(int[] array, int i, int j)
        {
            int aux = array[i];
            array[i] = array[j];
            array[j] = aux;
        }

        public static int EncontrarMenor(int[] array, int inicio)
        {
            int menor = inicio;
            for (int i = inicio + 1; i < array.Length; i++)
            {
                if (array[menor] > array[i])                
                    menor = i;                
            }
            return menor;
        }

        public static void OrdenarCrescente(int[] array)
        {
            for (int i = 0; i < array.Length; i++)            
                TrocaValores(array, i, EncontrarMenor(array, i));            
        }
    }
}
