using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar
{
    class Exercicio4
    {
        //Faça 4 listas com diferentes coleções, List, ArrayList, IList, Dictionary. Adicione dados em cada uma delas e no final liste-os
        static void Main4(string[] args)
        {
            List<int> lista = new List<int>();
            IList<int> iLista = new List<int>();
            ArrayList listaArray = new ArrayList();
            Dictionary<int, string> dicionario = new Dictionary<int, string>();
            Random geraNum = new Random();

            Console.WriteLine(" ===== List ===== \n");
            for (int i = 0; i < 10; i++)
            {
                lista.Add(geraNum.Next(0, 10));
                Console.Write("{0} ", lista[i]);
                if (i != 9)
                    Console.Write(" - ");  
            }

            Console.WriteLine("\n \n ===== IList ===== \n");
            for (int i = 0; i < 10; i++)
            {
                iLista.Add(geraNum.Next(0, 100));
                Console.Write("{0} ", iLista[i]);
                if (i != 9)
                    Console.Write(" - ");  
            }

            Console.WriteLine("\n \n ===== ArrayList ===== \n");
            for (int i = 0; i < 10; i++)
            {
                listaArray.Add(geraNum.Next(0, 500));
                Console.Write("{0} ", listaArray[i]);
                if (i != 9)
                    Console.Write(" - ");  
            }

            Console.WriteLine("\n \n ===== Dictionary ===== \n");
            for (int i = 0; i < 10; i++)
            {
                dicionario.Add(i, "Teste " + i);
                Console.WriteLine("{0} ",dicionario[i]);
            }

            Console.ReadKey();
        }
    }
}
