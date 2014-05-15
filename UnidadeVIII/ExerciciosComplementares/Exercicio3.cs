using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosComplementares
{
    class Exercicio3
    {
        //Para controlar o estacionamento de um condomínio, devemos implementar um programa em C# para gerar os cartões das vagas dos moradores.
        //Nos cartões, é necessário constar o número do bloco e o número do apartamento. Nesse condômino, há três blocos numerados de 1 a 3. 
        //Em cada bloco, há 9 andares. Em cada andar, há 4 apartamentos. No primeiro andar, os números dos
        //Apartamentos são: 11, 12, 13 e 14. 
        //No segundo andar, os números dos apartamentos são: 21, 22, 23 e 24. Nos outros andares, a lógica de numeração é a mesma. 

        public static void Main3()
        {
            Console.WriteLine("Controle do Estacionamento");
            int apart = 0;
            int count = 0;

            for (int i = 1; i <= 3; i++)
            {             
                for (int j = 1; j <= 9; j++)
                {                    
                    for (int k = 1; k <= 4; k++)
                    {
                        apart = (j * 10) + k;
                        Console.WriteLine("Bloco: {0} \nAndar: {1}º\nApartamento: {2}\n____________________", i, j, apart);
                        count ++;
                    }
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("Número de cartões: {0}", count);
            Console.ReadKey();
        }
    }
}
