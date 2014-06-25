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

        public static ArrayList TimesCopa = new ArrayList();

        static void Main(string[] args)
        {
            adicionarTimes();

            Console.ReadKey();
        }

        static void adicionarTimes()
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
