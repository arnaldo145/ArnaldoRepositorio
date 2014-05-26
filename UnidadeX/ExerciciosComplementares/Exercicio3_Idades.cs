using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.ExerciciosComplementares
{
    class Exercicio3_Idades
    {
        //Implemente um método que verifique a idade de 20 pessoas, um para comparar a maior idade, um para menor idade, outro para fazer
        //a média de todas as 20 idades e por fim imprimir todos esses dados. (5 métodos)

        static int[] Idades = new int[20];

        public static void Main3()
        {
            AtribuirValores();
            MaiorIdade();
            VerificarMenorIdade();
            CalcularMedia();
            Console.ReadKey();
        }

        static void AtribuirValores()
        {
            Random gerador = new Random();
            Console.WriteLine("MENSAGEM: Atribuindo valores aos itens do Array");
            for (int i = 0; i < Idades.Length; i++)
            {
                Idades[i] = gerador.Next(1, 90);
                Console.WriteLine(Idades[i]);
            }
        }

        static void MaiorIdade()
        {
            Console.WriteLine("\nMENSAGEM: Procurando maior idade");
            int maiorIdade = 0;
            for (int i = 0; i < Idades.Length; i++)
            {
                if(Idades[i] > maiorIdade){
                    maiorIdade = Idades[i];
                }
            }
            Console.WriteLine("Maior idade é {0} anos", maiorIdade);
        }

        static void VerificarMenorIdade()
        {
            Console.WriteLine("\nMENSAGEM: Procurando menor idade");
            int menorIdade = Idades[0];
            for (int i = 0; i < Idades.Length; i++)
            {
                if (Idades[i] < menorIdade)
                {
                    menorIdade = Idades[i];
                }
            }
            Console.WriteLine("Menor idade é {0} anos", menorIdade);
        }

        static void CalcularMedia()
        {
            Console.WriteLine("\nMENSAGEM: Calculando a média de idades");
            int count = 0;
            for (int i = 0; i < Idades.Length; i++)
            {
                count += Idades[i];
            }
            double media = count / Idades.Length;
            Console.WriteLine("Média de idade: {0:F1} anos", media);
        }
    }
}
