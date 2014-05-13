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
            Console.WriteLine("{0} com a nota {1:F1}",(nota > 0.7 ? "Aluno foi aprovado" : "Aluno foi reprovado"), nota);

            //Verifica Valor do Produto
            double valor = gerador.NextDouble();
            Console.WriteLine("R${0:F2}: {1}", valor, (valor > 0.5) ? "Preço é caro" : "Preço está em conta");      

            //EscolheCaminho
            double caminho = gerador.NextDouble();
            Console.WriteLine(caminho > 0.5 ? "Siga para direita" : "Siga para esquerda");

            Console.ReadKey();
        }
    }
}
