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
            //Aprovado-Reprovado
            Random gerador = new Random();
            double nota = gerador.NextDouble();
            if (nota > 0.7)
                Console.WriteLine("Aluno foi aprovado com a nota {0:F1}", nota);
            else
                Console.WriteLine("Aluno foi reprovado com a nota {0:F1}", nota);

            //Verifica Valor do Produto
            double valor = gerador.NextDouble();
            Console.WriteLine("R${0:F2}: {1}", valor, (valor > 0.5) ? "Preço é caro" : "Preço está em conta");
            Console.ReadKey();
        }
    }
}
