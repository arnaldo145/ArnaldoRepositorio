using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ===== VERIFICAÇÃO DE IDADE =====\n");
            Console.Write("Informe a idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Situação: {0} de idade", idade >= 18 ? "Maior" : "Menor");
            Console.ReadKey();
        }
    }
}
