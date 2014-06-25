using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeComplementar
{
    class Exercicio5
    {
        //Crie um algoritmo com uma coleção com todos dos times da copa. Sabe-se que são 64 times que serão sorteados e divididos em 8 grupos,
        //do A ao H. Depois de sorteados e alocados o algoritmo deve imprimir na tela todos os grupos.

        public static List<String> TimesCopa = new List<String>();
        public static List<String> GrupoA = new List<string>();
        public static List<String> GrupoB = new List<string>();
        public static List<String> GrupoC = new List<string>();
        public static List<String> GrupoD = new List<string>();
        public static List<String> GrupoE = new List<string>();
        public static List<String> GrupoF = new List<string>();
        public static List<String> GrupoG = new List<string>();
        public static List<String> GrupoH = new List<string>();


        static void Main(string[] args)
        {
            AdicionarTimes();
            SortearTimes();

            Console.WriteLine("Grupo A: \n");
            for (int i = 0; i < GrupoA.Count; i++)
                Console.WriteLine(GrupoA[i]);

            Console.WriteLine("\nGrupo B: \n");
            for (int i = 0; i < GrupoB.Count; i++)
                Console.WriteLine(GrupoB[i]);

            Console.WriteLine("\nGrupo C: \n");
            for (int i = 0; i < GrupoC.Count; i++)
                Console.WriteLine(GrupoC[i]);

            Console.WriteLine("\nGrupo D: \n");
            for (int i = 0; i < GrupoD.Count; i++)
                Console.WriteLine(GrupoD[i]);

            Console.WriteLine("\nGrupo E: \n");
            for (int i = 0; i < GrupoE.Count; i++)
                Console.WriteLine(GrupoE[i]);

            Console.WriteLine("\nGrupo F: \n");
            for (int i = 0; i < GrupoF.Count; i++)
                Console.WriteLine(GrupoF[i]);

            Console.WriteLine("\nGrupo G: \n");
            for (int i = 0; i < GrupoG.Count; i++)
                Console.WriteLine(GrupoG[i]);

            Console.ReadKey();
        }

        static void SortearTimes()
        {
            Random gerador = new Random();   

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gerador.Next(0, TimesCopa.Count);
                GrupoA.Add(TimesCopa[sorteio]);
                TimesCopa.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gerador.Next(0, TimesCopa.Count);
                GrupoB.Add(TimesCopa[sorteio]);
                TimesCopa.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gerador.Next(0, TimesCopa.Count);
                GrupoC.Add(TimesCopa[sorteio]);
                TimesCopa.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gerador.Next(0, TimesCopa.Count);
                GrupoD.Add(TimesCopa[sorteio]);
                TimesCopa.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gerador.Next(0, TimesCopa.Count);
                GrupoE.Add(TimesCopa[sorteio]);
                TimesCopa.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gerador.Next(0, TimesCopa.Count);
                GrupoF.Add(TimesCopa[sorteio]);
                TimesCopa.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gerador.Next(0, TimesCopa.Count);
                GrupoG.Add(TimesCopa[sorteio]);
                TimesCopa.RemoveAt(sorteio);
            }

            for (int i = 0; i < 4; i++)
            {
                int sorteio = gerador.Next(0, TimesCopa.Count);
                GrupoH.Add(TimesCopa[sorteio]);
                TimesCopa.RemoveAt(sorteio);
            }
        }
        static void AdicionarTimes()
        {
            TimesCopa.Add("Brasil");
            TimesCopa.Add("Argentina");
            TimesCopa.Add("Colômbia");
            TimesCopa.Add("Chile");
            TimesCopa.Add("Equador");
            TimesCopa.Add("Uruguai");
            TimesCopa.Add("Japão");
            TimesCopa.Add("Austrália");
            TimesCopa.Add("Irã");
            TimesCopa.Add("Coréia do Sul");
            TimesCopa.Add("Nigéria");
            TimesCopa.Add("Costa do Marfim");
            TimesCopa.Add("Gana");
            TimesCopa.Add("Camarões");
            TimesCopa.Add("Argélia");
            TimesCopa.Add("Alemanha");
            TimesCopa.Add("Suiça");
            TimesCopa.Add("Bélgica");
            TimesCopa.Add("Holanda");
            TimesCopa.Add("Rússia");
            TimesCopa.Add("Bósnia-Herzegóvina");
            TimesCopa.Add("Itália");
            TimesCopa.Add("Inglaterra");
            TimesCopa.Add("Espanha");
            TimesCopa.Add("Grécia");
            TimesCopa.Add("Croácia");
            TimesCopa.Add("Portugal");
            TimesCopa.Add("França");
            TimesCopa.Add("Estados Unidos");
            TimesCopa.Add("Costa Rica");
            TimesCopa.Add("México");
            TimesCopa.Add("Honduras");
        }



    }
}
