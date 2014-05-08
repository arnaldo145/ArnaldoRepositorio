using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreV
{
    class Questao9_Produto
    {
        static void Main9(string[] args)
        {
            bool terminado = false;
            Console.WriteLine(" ===== NOTA FISCAL =====\n");

            do
            {
                 double total = 0;
                 double totalPagar = 0;
                 int desconto = 0;
                
                Console.Write("Informe a descrição do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Informe a quantidade adquirida: ");
                int qtdAdquirida = int.Parse(Console.ReadLine());
                Console.Write("Informe o preço unitário do produto: ");
                double precoUnitario = double.Parse(Console.ReadLine());

                total = qtdAdquirida * precoUnitario;
                
                if (qtdAdquirida <= 5)
                {
                    totalPagar = total - (total * 0.02);
                    desconto = 2;
                }

                if (qtdAdquirida > 5 & qtdAdquirida <= 10)
                {
                    totalPagar = total - (total * 0.03);
                    desconto = 3;
                }

                if (qtdAdquirida > 10)
                {
                    totalPagar = total - (total * 0.05);
                    desconto = 5;
                }

                Console.WriteLine("\nTotal: R${0}\nDesconto: {1}% \nTotal a pagar: R${2}\n", total, desconto, totalPagar);
                
                Console.Write("\nDeseja continuar (S - Sim / N - Não): ");
                string status = Console.ReadLine();
                terminado = (status.ToUpper() == "N" ? true : false);

            } while (terminado != true);
        }
    }
}
