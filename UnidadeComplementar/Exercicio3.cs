using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar
{
    class Exercicio3
    {
        //Faça um programa que leia n nomes inserindo-os em uma lista de forma ordenada utilizando a ideia do algoritmo da inserção. 
        //No final, o programa deve mostrar todos os nomes ordenados alfabeticamente. 

        static void Main3(string[] args)
        {
            ArrayList nomes = new ArrayList();

            Console.WriteLine(" ===== NOMES ===== \n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();
                nomes.Add(nome);
                nomes.Sort();
            }

            Console.WriteLine("\n ===== NOMES ORDENADOS ===== \n");
            for (int i = 0; i < nomes.Count; i++)            
                Console.WriteLine("{0} - {1}", i, nomes[i]);            

            Console.ReadKey();
        }
    }
}
