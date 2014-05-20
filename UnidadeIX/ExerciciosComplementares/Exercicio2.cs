using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeIX.ExerciciosComplementares
{
    class Exercicio2
    {
        //Considere um programa de computador que controla as vagas de um estacionamento. Esse programa deve armazenar em uma tabela (array de arrays)
        //a situação das vagas (ocupada ou livre) por andar. Implemente um programa em C# que defina aleatoriamente a situação das vagas de um estacionamento 
        //de quatro andares numerados de 1 a 4. Considere que a capacidade de cada andar é de 10 vagas. Complete o código a seguir.

        static void Main2(string[] args)
        {
            Console.WriteLine(" ===== CONTROLE DE ESTACIONAMENTO ===== ");
            Console.WriteLine("\nO - Ocupado / L - Livre \n");
            char[,] tabelaEstacionamento = new char[4, 10];
            Random gerador = new Random();

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Andar {0}: ", (i+1));
                for (int j = 0; j < 10; j++)
                {
                    //Intervalo do Random termina em 3 para que apareça número 2
                    int status = gerador.Next(1, 3);

                    if (status == 1)                    
                        tabelaEstacionamento[i, j] = 'O';                    
                    if (status == 2)                    
                        tabelaEstacionamento[i, j] = 'L';                    
                    Console.Write("{0} ", tabelaEstacionamento[i,j]);
                }
                Console.WriteLine("---------------------------------\n ");
            }
            Console.ReadKey();
        }
    }
}
