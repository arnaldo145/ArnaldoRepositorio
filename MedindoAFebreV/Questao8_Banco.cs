using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreV
{
    class Questao8_Banco
    {
        static void Main8(string[] args)
        {
            Console.WriteLine(" ===== EXPEDIENTE DO BANCO =====\n");
            int countPessoas = 0;
            bool terminado = false;
            DateTime inicio = Convert.ToDateTime("10:00");
            DateTime termino = Convert.ToDateTime("16:00");

            do
            {            
                Console.Write("Informe a hora da entrada (HH:MM): ");
                string horaEntrada = Console.ReadLine();
                DateTime entrada = Convert.ToDateTime(horaEntrada);

                countPessoas += (entrada >= inicio && entrada <= termino) ? 1 : 0;

                Console.Write("\nDeseja continuar (1 - SIM / 2 - NÃO): ");
                int opcao = int.Parse(Console.ReadLine());
                terminado = (opcao == 2 ? true : false);
            } while (terminado == false);

            Console.WriteLine("\nPessoas que entraram na hora do expediente: {0}", countPessoas);
            Console.ReadKey();
        }

    }
}
