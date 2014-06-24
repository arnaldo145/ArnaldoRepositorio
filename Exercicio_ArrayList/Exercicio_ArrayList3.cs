using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ArrayList
{
    class Exercicio_ArrayList3
    {
        static void Mainj(string[] args)
        {
            //Faça um algoritmo que leia dois vetores (A e B) de 50 posições de números inteiros. O algoritmo deve, então, subtrair o 
            //primeiro elemento de A do último de B, acumulando o valor, subtrair o segundo elemento de A do penúltimo de B, acumulando
            //o valor, e assim por diante. Mostre o resultado da soma final.

            Console.WriteLine(" ===== SOMA DE VALORES ===== \n");
            Random gerador = new Random();
            ArrayList listA = new ArrayList();
            ArrayList listB = new ArrayList();

            for (int i = 0; i < 50; i++)
            {
                listA.Add(gerador.Next(0, 100));
                listB.Add(gerador.Next(0, 100));
            }

            int soma = 0;
            int pos = 49;

            for (int i = 0; i < listA.Count; i++)
            {                
                soma = (int) listA[i] - (int) listB[pos];
                Console.WriteLine("{0} - {1} = {2}", listA[i], listB[pos], (int)listA[i] - (int)listB[pos]);
                pos--;
            }
            Console.WriteLine("\n \nSoma: {0}", soma);
            Console.ReadKey();
        }
    }
}
