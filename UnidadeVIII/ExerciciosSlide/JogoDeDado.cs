using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosSlide
{
    class JogoDeDado
    {
        public static void Main()
        {
            int count = 0;

            Console.WriteLine("Jogo de dados: ");

            for (int i = 0; i < 5; i++)
            {
                count += jogarDados();
            }

            if (count > 19)
            {
                Console.WriteLine("Ganhou! Pontos obtidos: {0}", count);
            }
            else
            {
                Console.WriteLine("Perdeu! Pontos obtidos: {0}", count);
            }
            Console.ReadKey();
        }

        static int jogarDados()
        {
            Random gerador = new Random();
            return gerador.Next(1,6);
        }
    }
}
