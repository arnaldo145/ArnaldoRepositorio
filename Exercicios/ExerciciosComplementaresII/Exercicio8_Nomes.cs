using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares_UnidadeVI
{
    class Exercicio8_Nomes
    {
        //Quando se lista o nome de autores de livros, artigos e outras publicações é comum que se 
        //apresente o nome do autor ou dos autores da seguinte forma: sobrenome do autor em letras 
        //maiúsculas, seguido de uma vírgula e da primeira parte do nome apenas com as iniciais maiúsculas.
        //Por exemplo:

        //SILVA, Joao
        //COELHO, Paulo
        //ARAUJO, Celso de

        //Seu desafio é fazer um programa que leia um número inteiro correspondendo ao número de nomes que 
        //será fornecido, e, a seguir, leia estes nomes (que podem estar em qualquer tipo de letra) e imprima
        //a versão formatada no estilo exemplificado acima.

        static void Main8(string[] args)
        {
            Console.Write("Informe o número de nomes: ");
            int quantidadeNomes = int.Parse(Console.ReadLine());
            string[] nomes = new string[quantidadeNomes];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Informe o nome: ");
                nomes[i] = Console.ReadLine();
            }

            for (int i = 0; i < nomes.Length; i++)
            {
                var nome = nomes[i].Split();
                Console.Write("\n{0}, ", nome[nome.Length - 1].ToUpper());

                for (int j = 0; j < nome.Length - 1; j++)
                {
                    Console.Write("{0} ", nome[j]);
                }
            }

            Console.ReadKey();
        }
    }
}
