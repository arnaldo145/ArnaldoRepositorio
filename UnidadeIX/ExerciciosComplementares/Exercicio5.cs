using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.ExerciciosComplementares
{
    class Exercicio5
    {
        //Escreva um algoritmo que leia um vetor de 10 posições do tipo caracter, que representa o gabarito de uma prova. A seguir, 
        //para cada um dos 20 alunos da turma, leia o vetor de respostas (R) do aluno de 10 posições do tipo caracter e conte o 
        //número de acertos. Mostre o nº de acertos do aluno e uma mensagem APROVADO, se a nota for maior ou igual a 6; e mostre uma 
        //mensagem de REPROVADO, caso contrário.

        static void Main5(string[] args)
        {
            Random gerador = new Random();
            char[] gabarito = new char[10];
            char[] questoes = new char[]{'A', 'B', 'C', 'D', 'E'};

            Console.WriteLine(" ===== Gabarito ===== \n");
            for (int i = 0; i < gabarito.Length; i++)
            {
                gabarito[i] = questoes[gerador.Next(0, questoes.Length)];
                Console.WriteLine("Questão {0}: {1}", (i+1), gabarito[i]);
            }

            Console.WriteLine(" ");

            for (int i = 0; i < 20; i++)
            {
                int count = 0;
                Console.WriteLine(" ----- Aluno {0} -----", (i + 1));

                char[] resposta = new char[10];
                Console.Write("\nRespostas: ");
                for (int j = 0; j < resposta.Length; j++)
                {
                    resposta[j] = questoes[gerador.Next(0, questoes.Length)];
                    Console.Write("{0} ", resposta[j]);
                    if(resposta[j] == gabarito[j]){
                        count++;
                    }
                }

                Console.WriteLine("\nNúmero de acertos: {0}", count);
                Console.WriteLine("{0} \n", count >= 6 ? "Aprovado" : "Reprovado");
            }
                Console.ReadKey();
        }
    }
}
