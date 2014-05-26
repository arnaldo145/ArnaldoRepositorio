using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.ExerciciosComplementares
{
    class Exercicio2_DataValida
    {
        //2) Implemente um método que verifica se uma determinada data é válida ou não. Lembre-se que Janeiro, Março, Maio, Julho, Agosto,
        //Outubro e Dezembro possuem 31 dias; Abril, Junho, Setembro e Novembro possuem 30 dias; e Fevereiro possui 28 dias em anos não 
        //bissextos e 29 dias em anos bissextos.

        public static void Main()
        {
            Console.WriteLine(" ===== VERIFICAR DATA VÁLIDA =====");
            Console.Write("Informe o dia do mês (DD): ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Informe o mês (MM): ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Informe o ano (AAAA): ");
            int ano = int.Parse(Console.ReadLine());
            if(VerificarDataValida(dia, mes, ano) == true){
                Console.WriteLine("\nData válida");
            } else {
                Console.WriteLine("\nDatá inválida");
            }
            Console.ReadKey();
        }

        static bool VerificarDataValida(int diaVerificar, int mesVerificar, int anoVerificar)
        {
            bool bissexto = VerificarAnoBissexto(anoVerificar);

            switch (mesVerificar)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                case 11:
                    if(diaVerificar >= 1 && diaVerificar <= 31){
                        return true;
                    } else {
                        return false;
                    }
                case 4:
                case 6:
                case 8:
                case 10:
                case 12:
                    if (diaVerificar >= 1 && diaVerificar <= 30)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 2:
                    if (!bissexto)
                    {
                        if (diaVerificar >= 1 && diaVerificar <= 28)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (diaVerificar >= 1 && diaVerificar <= 29)
                        {
                            return true;
                        }
                        else
                        {
                            return false;                      
                        }
                    }
                default:
                    return false;
            }
        }

        static bool VerificarAnoBissexto(int anoVerificado)
        {
            if ((anoVerificado % 4 == 0) && ((anoVerificado % 100 != 0) || (anoVerificado % 400 == 0)))
                return true;
            else
                return false;
        }
    }
}
