using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares_UnidadeVI
{
    class Exercicio3_PesoIdeal
    {
        // Tendo como entrada a altura e o sexo (codificado da seguinte forma: 1:feminino 2:masculino) de 
        //uma pessoa, construa um programa que calcule e imprima seu peso ideal, utilizando as seguintes fórmulas:  
        //  - para homens : (72.7 * altura) – 58 
        //  - para mulheres : (62.1 * altura) – 44.7 

        static void Main3(string[] args)
        {
            double pesoIdeal = 0;

            Console.WriteLine("===== PESO IDEAL =====");

            Console.Write("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Informe o sexo (1 - Feminino / 2 - Masculino): ");
            int sexo = int.Parse(Console.ReadLine());

            if (sexo == 2)
            {
                Console.WriteLine("Peso Ideal para Homens: ");
                pesoIdeal = ((72.7 * altura) - 58);
                Console.WriteLine("Peso Ideal: {0} quilos", pesoIdeal);
            }

            if (sexo == 1)
            {
                Console.WriteLine("Peso Ideal para Mulheres: ");
                pesoIdeal = ((62.1 * altura) - 44.7);
                Console.WriteLine("Peso Ideal: {0} quilos", pesoIdeal);
            }

            if (sexo != 1 && sexo != 2)
            {
                Console.WriteLine("ATENÇÃO: Opção 'Sexo' foi informada de maneira incorreta!");
            }

            Console.ReadKey();
        }
    }
}
