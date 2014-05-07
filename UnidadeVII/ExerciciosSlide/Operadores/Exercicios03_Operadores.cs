using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExerciciosSlide.Operadores
{
    class Exercicios03_Operadores
    {
        static void Main(string[] args)
        {
            //Operador Ternário
            int idade = 19;

            string resultado = (idade > 18 ? "Maior de idade" : "Menor");

            Console.WriteLine("{0}", resultado);

            //Pré-Incremento e Pós incremento
            int valor = 5;
            Console.WriteLine(valor++);

            valor = 10;
            Console.WriteLine(++valor);

            valor = 25;
            Console.WriteLine(valor--);

            valor = 30
                ;
            Console.WriteLine(--valor);

            Console.ReadKey();
        }
    }
}
