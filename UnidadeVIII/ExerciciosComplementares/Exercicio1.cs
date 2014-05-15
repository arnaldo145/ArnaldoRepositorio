using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosComplementares
{
    class Exercicio1
    {
        // Crie um programa em C# que gere dois números aleatórios e exiba o valor desses números. Além disso, esse programa
        // deve exibir a mensagem “Primeiro > Segundo” se o primeiro número for maior do que o segundo, a mensagem “Segundo >
        //Primeiro” se o segundo número for maior do que o primeiro e mensagem “Primeiro = Segundo” se o primeiro número for 
        //igual ao segundo.

        public static void Main1()
        {
            Random geraNumero = new Random();
            int num1 = geraNumero.Next(1, 100);
            int num2 = geraNumero.Next(1, 100);

            Console.WriteLine("Valor 1: {0} \nValor 2: {1}", num1, num2);

            if (num1 > num2)
                Console.WriteLine("Primeiro > Segundo");

            if (num2 > num1)
                Console.WriteLine("Segundo > Primeiro");

            if (num2 == num1)
                Console.WriteLine("Primeiro = Segundo");

            Console.ReadKey();
        }
    }
}
