using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreVI
{
    class Questao12
    {
        public static void Main()
        {
            Random gerador = new Random();

            int numMatricula = 0;
            int maiorNota = 0;
            int menorNota = 100;
            double countMedia = 0;
            int countReprovados = 0;

            for (int i = 0; i < 100; i++)
            {
                numMatricula++;
                Console.WriteLine("Matricula: {0}", numMatricula);

                //Considerando que a nota seja de 0 a 100
                int nota1 = gerador.Next(0, 100);
                int nota2 = gerador.Next(0, 100);
                int nota3 = gerador.Next(0, 100);
                Console.WriteLine("Nota 1: {0} \nNota 2: {1} \nNota 3: {2}", nota1, nota2, nota3);
             
                //Considerando que total de dias de aula sejam 100
                int frequencia = gerador.Next(0, 100);
                Console.WriteLine("Frequencia: {0} aulas comparecidas", frequencia);
                
                Console.WriteLine("Nota final: {0}", calcularNotaFinal(nota1, nota2, nota3));

                if (verificarMaiorNota(nota1, nota2, nota3) > maiorNota)
                {
                    maiorNota = verificarMaiorNota(nota1, nota2, nota3);
                }

                if(menorNota > verificarMenorNota(nota1, nota2, nota3)){
                    menorNota = verificarMenorNota(nota1, nota2, nota3);
                }

                countMedia += calcularNotaFinal(nota1, nota2, nota3);

                if (!verificarAprovado(calcularNotaFinal(nota1, nota2, nota3), frequencia)){
                    Console.WriteLine("Situação: Reprovado");
                    countReprovados++;
                } else {
                    Console.WriteLine("Situação: Aprovado");
                }

                Console.WriteLine("--------------------------------------------------------\n");
            }

            Console.WriteLine("\nMaior nota: {0} \nMenor nota: {1}", maiorNota, menorNota);
            Console.WriteLine("Nota média da turma: {0:F} \nAlunos reprovados: {1}", countMedia / 100, countReprovados);
            Console.ReadKey();
        }

        static bool verificarAprovado(double notaFinal, int frequencia)
        {
            if(notaFinal >= 60 && frequencia >= 40){
                return true;
            } else {
                return false;
            }
        }

        static double calcularNotaFinal(int n1, int n2, int n3)
        {
            return (n1 + n2 + n3) / 3;
        }

        static int verificarMaiorNota(int n1, int n2, int n3)
        {
            int[] notasAluno = new int[] {n1, n2, n3 };
            int maior = 0;
            for (int i = 0; i < 3; i++)
            {
                if (notasAluno[i] > maior){
                    maior = notasAluno[i];
                }
            }
            return maior;
        }

        static int verificarMenorNota(int n1, int n2, int n3)
        {
            int[] notasAluno = new int[] { n1, n2, n3 };
            int menor = notasAluno[0];

            for (int i = 0; i < 3; i++)
            {
                if (menor > notasAluno[i])
                {
                    menor = notasAluno[i];
                }
            }
            return menor;
        }
    }
}
