using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar
{
    class Exercicio1
    {
        //Faça um algoritmo que adicione 100 números em qualquer coleção que vocês preferir, ao final imprima esses números decrescente e depois crescente.

        static void Main1(string[] args)
        {
            ArrayList valores = new ArrayList();
            Random gerador = new Random();

            for (int i = 0; i < 100; i++)            
                valores.Add(gerador.Next(0, 1000));

            valores.Sort();

            Console.WriteLine(" ===== ORDEM CRESCENTE ===== \n");
            for (int i = 0; i < valores.Count; i++)
            {
                Console.Write("{0}", valores[i]);
                if (i != (valores.Count - 1))                
                    Console.Write(" - ");                
            }

            Console.WriteLine("\n \n ===== ORDEM DECRESCENTE ===== \n");
            for (int i = (valores.Count - 1); i >= 0; i--)
            {
                Console.Write("{0}", valores[i]);
                if (i != 0)
                    Console.Write(" - "); 
            }

            Console.ReadKey();
        }
    }
}
