using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosSlide
{
    class ControleDeFluxo
    {
        public static void Main()
        {
            Random gerador = new Random();

            //Aprovado-Reprovado   
            double nota = gerador.NextDouble();
            Console.WriteLine("Nota: {0:F1}", nota);
            if (nota > 0.7) {
                Console.WriteLine("Aluno foi aprovado");
            } else{
                Console.WriteLine("Aluno foi reprovado");
            }

            //Verifica Valor do Produto
            double valor = gerador.NextDouble();
            Console.WriteLine("\nPreço: R${0:F2}",valor);
            if (valor > 0.5) {
                Console.WriteLine("Preço é caro");
            } else {
                Console.WriteLine("Preço é caro");
            }

            //EscolheCaminho
            double caminho = gerador.NextDouble();
            Console.WriteLine("\nCaminho: {0:F2}", caminho);
            if (caminho > 0.5) {
                Console.WriteLine("Siga para direita");
            } else {
                Console.WriteLine("Siga para esquerda");
            }

            //EscolheRoupa
            double roupa = gerador.NextDouble();
            Console.WriteLine("\nRoupa: {0:F2}", roupa);
            if (caminho > 0.5) {
                Console.WriteLine("Vista uma camisa vermelha");
            } else {
                Console.WriteLine("Vista uma camisa azul");
            }

            //ADividioPorB
            int a = gerador.Next(1,100);
            int b = gerador.Next(1,100);

            if (a % b == 0) {
                Console.WriteLine("\n{0} é divisivel por {1}\n", a, b);
            } else {
                Console.WriteLine("\n{0} não é divisivel por {1}\n", a, b);
            }

            //InstruçõesRepetições
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("NDDigital Technologies {0}", i);
            }

            Console.WriteLine(" ");

            //Imprime100
            int z = 1;
            while (z <= 100)
            {
                Console.WriteLine("{0}", z);
                z++;
            }

                Console.ReadKey();
        }
    }
}
