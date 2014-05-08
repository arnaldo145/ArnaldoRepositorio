using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreV
{
    class Program
    {
        static void Main7(string[] args)
        {
            Console.Write("Informe a idade: ");
            int idade = int.Parse(Console.ReadLine());

            string status = idade >= 18 ? "Maior" : "Menor";

            Console.WriteLine("Situação: {0} de idade", status);
            Console.ReadKey();
        }
    }
}
