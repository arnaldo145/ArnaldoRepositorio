using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares_UnidadeVI
{
    class Exercicio6_ConcursoBeleza
    {
        //Escreva um programa que leia o primeiro nome e a altura das moças inscritas em um 
        //concurso de beleza. Quando for informada a palavra FIM para o nome da moça o programa
        //deverá ser encerrado e imprimir: o nome e a altura da moça mais alta e o número de 
        //moças no concurso. Considere que todas as moças possuem altura diferente.

        static void Main6(string[] args)
        {
            Console.WriteLine(" ===== CONCURSO DE BELEZA =====");

            int contadorCandidatas = 0;
            string candidataMaisAlta = null;
            double alturaMaisAlta = 0;
            int numeroCandidatas = 1;
            double altura = 0;

            for (int i = 0; i < numeroCandidatas; i++)
            {
                Console.Write("Informe o nome da candidata: ");
                string nomeCandidata = Console.ReadLine();

                if (nomeCandidata.ToLower() == "fim")
                {
                    Console.WriteLine("\nCandidata mais alta: {0} \nAltura: {1}", candidataMaisAlta, alturaMaisAlta);
                    Console.WriteLine("Número de candidatas: {0}", contadorCandidatas);
                }
                else
                {
                    Console.Write("Informe a altura da candidata: ");
                    altura = double.Parse(Console.ReadLine());

                    if (altura > alturaMaisAlta)
                    {
                        alturaMaisAlta = altura;
                        candidataMaisAlta = nomeCandidata;
                    }

                    numeroCandidatas += 1;
                    contadorCandidatas += 1;
                }
            }
            Console.ReadKey();
        }
    }
}
