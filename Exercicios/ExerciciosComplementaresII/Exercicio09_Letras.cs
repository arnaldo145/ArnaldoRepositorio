using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosComplementaresII
{
    //Se você pensar em um papel como um plano e uma letra como uma marcação neste plano, então estas 
    //letras dividem o plano em regiões. Por exemplo, as letras A, D e O dividem o plano em 2 pois 
    //possuem um espaço confinado em seu desenho, ou um “buraco”. Outras letras como B possuem 2 buracos
    //e letras como C e E não possuem buracos.
    //Deste modo podemos considerar que o número de buracos em um texto é igual a soma dos buracos nas 
    //palavras dele.
    //A sua tarefa é, dado um texto qualquer, encontre a quantidade de buracos nele.

    class Exercicio09_Letras
    {
        static void Main9(string[] args)
        {
            Console.WriteLine("     CONTADOR DE BURACOS NO TEXTO");
            Console.Write("\nDigite um texto: ");
            string texto = Console.ReadLine();
            int contador = contarBuracos(texto.ToUpper());
            Console.WriteLine("\nExistem {0} buracos no texto a seguir: \n{1}", contador, texto.ToUpper());
            Console.ReadKey();
        }

        static int contarBuracos(string textoCont)
        {
            int count = 0;
            var letrasTexto = textoCont.ToCharArray();
            for (int i = 0; i < textoCont.Length; i++)
            {
                switch (textoCont[i])
                {
                    case 'Q':
                    case 'R':
                    case 'O':
                    case 'P':
                    case 'A':
                    case 'D':
                        count += 1;
                        break;
                    case 'B':
                        count += 2;
                        break;
                    default:
                        count += 0;
                        break;
                }
            }
                return count;
        }

    }
}
