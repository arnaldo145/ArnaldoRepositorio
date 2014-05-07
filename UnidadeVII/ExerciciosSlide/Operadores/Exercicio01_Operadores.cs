using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExerciciosSlide
{
    class Exercicio01_OperadoresAritmeticos
    {
        static void Main1(string[] args)
        {
            int resultado = 0;

            //Na classe com nome Operadores, implemente um programa em C# que utilize todos os operadores aritméticos.
            resultado = 1 + 1;
            resultado = 2 - 1;
            resultado = 3 * 2;
            resultado = 10 / 2;
            resultado = 10 % 5;

            //Na pasta operadores, implemente um programa em C# que realize operações de divisão inteira e de casting.
            resultado = 5 / 2;
            Console.WriteLine((double)7 / 2);

            //Na pasta operadores, implemente um programa em C# que realize operações de concatenação de strings.

            string nome = "Arnaldo";
            string space = " ";
            string sobrenome = "Madeira";
            string result = nome + space + sobrenome;
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
