using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosSlide
{
    class JogoDeDado2
    {
        public static void Main()
        {
            int count = 0;

            for (int i = 0; i < 4; i++)
            {
                int result = jogarDados();
                Console.WriteLine(result);
                if (result % 2 != 0){
                    count += result;
                }
            }

            if (count > 9){
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
            return gerador.Next(1, 6);
        }
    }
}
