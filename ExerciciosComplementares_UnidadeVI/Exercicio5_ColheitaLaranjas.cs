using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares_UnidadeVI
{
    class Exercicio5_ColheitaLaranjas
    {
        //Um fazendeiro vai contratar uma equipe de trabalhadores para a colheita de laranjas de sua fazenda. 
        //Os trabalhadores serão identificados por um número e pela sua idade. O fazendeiro pagará aos 
        //trabalhadores no final do dia conforme a quantidade de caixas colhidas segundo a tabela abaixo:
        //Além disso, o fazendeiro pagará um adicional conforme a idade do trabalhador segundo a tabela abaixo:

        static void Main5(string[] args)
        {
            Console.Write("Informe a quantidade de trabalhadores contratados: ");
            int qtdTrabalhadores = int.Parse(Console.ReadLine());

            int[] codigo = new int[qtdTrabalhadores];
            int[] idade = new int[qtdTrabalhadores];
            int[] caixas = new int[qtdTrabalhadores];

            for (int i = 0; i < qtdTrabalhadores; i++)
            {
                Console.WriteLine("\n ===== CADASTRO DA COLHEITA ===== \n");

                Console.Write("Informe o código do trabalhador: ");
                codigo[i] = int.Parse(Console.ReadLine());
                Console.Write("Informe a idade do trabalhador: ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.Write("Informe o número de caixas colhidas pelo trabalhador: ");
                caixas[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n ===== FOLHA DE PAGAMENTO =====");

            for (int i = 0; i < qtdTrabalhadores; i++)
            {
                double salarioTrabalhador = 0;

                if (caixas[i] <= 5)
                {
                    salarioTrabalhador = caixas[i] * 2;
                }

                if (caixas[i] >= 6 && caixas[i] <= 10)
                {
                    salarioTrabalhador = caixas[i] * 2.50;
                }

                if (caixas[i] >= 11 && caixas[i] <= 20)
                {
                    salarioTrabalhador = caixas[i] * 3.50;
                }

                if (caixas[i] >= 21)
                {
                    salarioTrabalhador = caixas[i] * 5;
                }

                if (idade[i] >= 18 && idade[i] < 45)
                {
                    salarioTrabalhador += (salarioTrabalhador * 0.1);
                }

                if (idade[i] >= 45 && idade[i] < 65)
                {
                    salarioTrabalhador += (salarioTrabalhador * 0.2);
                }

                Console.WriteLine("\nCódigo do Trabalhador: {0} \nIdade do Trabalhador: {1} \nCaixas colhidas pelo trabalhador: {2} \nSalário do trabalhador: R$ {3}\n", codigo[i], idade[i], caixas[i], salarioTrabalhador);
            }

            Console.ReadKey();
        }
    }
}
