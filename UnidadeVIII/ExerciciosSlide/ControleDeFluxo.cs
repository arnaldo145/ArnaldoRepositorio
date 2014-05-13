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
            if (nota > 0.7)
            {
                Console.WriteLine("Aluno foi aprovado");
            } else{
                Console.WriteLine("Aluno foi reprovado");
            }

            //Verifica Valor do Produto
            double valor = gerador.NextDouble(); 
            if(valor > 0.5){
                Console.WriteLine("Preço é caro");
            } else {
                Console.WriteLine("Preço é caro");
            }

            //EscolheCaminho
            double caminho = gerador.NextDouble();
            if (caminho > 0.5)
            {
                Console.WriteLine("Siga para direita");
            } else {
                Console.WriteLine("Siga para esquerda");
            }

            //EscolheRoupa
            double roupa = gerador.NextDouble();
            if (caminho > 0.5)
            {
                Console.WriteLine("Vista uma camisa vermelha");
            } else {
                Console.WriteLine("Vista uma camisa azul");
            }

            //ADividioPorB
            int a = gerador.Next(1,100);
            int b = gerador.Next(1,100);

            if (a % b == 0)
            {
                Console.WriteLine("{0} é divisivel por {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} não é divisivel por {1}", a, b);
            }

            Console.ReadKey();
        }
    }
}
