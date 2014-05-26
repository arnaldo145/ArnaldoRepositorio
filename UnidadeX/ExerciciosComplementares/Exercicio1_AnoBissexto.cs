using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.ExerciciosComplementares
{
    class Exercicio1_AnoBissexto
    {
        //1) Implemente um método que determina seu ano é ou não é bissexto. As regras para determinar se um ano é bissexto são:
        //1. Anos múltiplos de 4 são bissextos.
        //2. Anos múltiplos de 100 não são bissextos.
        //3. Anos múltiplos de 400 são bissextos.
        //4. As últimas regras prevalecem sobre as primeiras.

        public static void Main1()
        {
            Console.WriteLine(" ===== ANO BISSEXTO =====");
            Console.Write("Informe o ano: ");
            int ano = int.Parse(Console.ReadLine());
            if (!VerificarAno(ano))            
                Console.WriteLine("\n{0} não é ano bissexto", ano);            
            else            
                Console.WriteLine("\n{0} é ano bissexto", ano);            
            Console.ReadKey();
        }

        static bool VerificarAno(int anoVerificado)
        {          
            if ((anoVerificado % 4 == 0) && ((anoVerificado % 100 != 0) || (anoVerificado % 400 == 0)))
                return true;
            else
                return false;
        }
    }
}
