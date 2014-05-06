using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosComplementaresII
{
    class Exercicio10_NumerosAmigos
    {
        //Escreva um programa que leia 5 pares de valores positivos. Imprima se os elementos de cada
        //par são números amigos. Dois números A e B são amigos se a soma dos divisores de A excluindo
        //A é igual a B e a soma dos divisores de B excluindo B é igual a A. Para a verificar se dois 
        //números são amigos utilize uma função (Método).  
        //Exemplo: 
        //220 e 284 são amigos, pois 
        //220: 1+2+4+5+10+11+20+22+44+55+110=284 
        //284: 1+2+4+71+142=220 
        //1184 e 1210 também são amigos.  

        static void Main(string[] args)
        {
            int[] valorA = new int[5];
            int[] valorB = new int[5];            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n ===== PAR {0} ===== \n", (i + 1));
                Console.Write("Informe o valor para A: ");
                valorA[i] = int.Parse(Console.ReadLine());
                Console.Write("Informe o valor para B: ");
                valorB[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n ===== RESULTADO =====;");

            for (int i = 0; i < 5; i++)
            {
                bool status = verificarNumerosAmigos(valorA[i], valorB[i]);

                if (!status)
                {
                    Console.WriteLine("\nOs valores {0} e {1} NÃO são números amigos", valorA[i], valorB[i]);
                }
                else
                {
                    Console.WriteLine("\nOs valores {0} e {1} são números amigos", valorA[i], valorB[i]);
                }
            }
            Console.ReadKey();
        }

        static bool verificarNumerosAmigos(int valor1, int valor2)
        {
            int somaMultiplosA = somarMultiplos(valor1);
            int somaMultiplosB = somarMultiplos(valor2);

            if (somaMultiplosA == valor2 && somaMultiplosB == valor1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int somarMultiplos(int valor)
        {
            int somaMultiplos = 0;
            for (int j = 0; j < valor; j++){
                if (valor % (j + 1) == 0 && (j + 1) != valor){
                    somaMultiplos += (j + 1);
                }
            }
            return somaMultiplos;
        }
    }
}
