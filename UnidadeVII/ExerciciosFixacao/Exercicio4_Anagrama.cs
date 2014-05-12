using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExerciciosFixacao
{
    class Exercicio4_Anagrama
    {
        //Escreva um programa que gere todos os anagramas potenciais de uma string.
        //Por exemplo, os anagramas potenciais de "biro" são:
        //    biro bior brio broi boir bori
        //    ibro ibor irbo irob iobr iorb
        //    rbio rboi ribo riob roib robi
        //    obir obri oibr oirb orbi orib
        public static List<string> Anagramas = new List<string>();

        public static void Main()
        {
            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();
            if (palavra != null) Anagrama(palavra, palavra.Length);
            foreach (var anagrama in Anagramas)
            {
                Console.Write("{0} ", anagrama);
            }
            Console.ReadKey();
        }

        public static void Anagrama(string palavra, int tamanho)
        {
            if (tamanho == 1)
            {
                if (!Anagramas.Contains(palavra))
                    Anagramas.Add(palavra);
            }
            else
            {
                string palavraAtual = palavra;
                for (int i = 0; i < tamanho; i++)
                {
                    palavraAtual = palavraAtual.Substring(1, tamanho - 1) + palavraAtual[0] + palavraAtual.Substring(tamanho);
                    Anagrama(palavraAtual, tamanho - 1);
                }
            }
        }
    }
}
