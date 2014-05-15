using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosComplementares
{
    class Exercicio6
    {
        //Crie um programa em C# que gere e exiba no terminal um número aleatório. 
        //Além disso, esse programa deve contabilizar a quantidade de dígitos “1” 
        //do número aleatório e exibir essa quantidade no terminal. Complete o código abaixo.

        public static void Main()
        {
            Random gerador = new Random();
            int valorAleatorio = gerador.Next();
            int count = 0;           

            var valor = valorAleatorio.ToString().ToCharArray();
            for (int i = 0; i < valor.Length; i++)
            {
                if(valor[i] == '1'){
                    count++;
                }
            }

            Console.WriteLine("Valor aleatório: {0} \nQuantidade de dígitos 1: {1}", valorAleatorio, count);

            Console.ReadKey();
        }
    }
}
