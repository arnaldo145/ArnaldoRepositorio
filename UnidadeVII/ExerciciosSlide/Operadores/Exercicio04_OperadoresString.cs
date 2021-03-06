﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVII.ExerciciosSlide.Operadores
{
    class Exercicio04_OperadoresString
    {
        static void Maini(string[] args)
        {
            //Contar carcteres de um string
            string n = "Arnaldo";
            int qtd = n.Length;
            Console.WriteLine("{0} tem {1} caracteres", n, qtd);

            //Pegar um caractere de um string
            char c = n[0];
            Console.WriteLine("{0}", c);


            string s = "Apostila de Java";

            bool resultado1 = s.Contains("C#");
            bool resultado2 = s.Contains("Java");
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);

            resultado1 = s.EndsWith("C#");
            resultado2 = s.EndsWith("Java");
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);

            resultado1 = s.StartsWith("Apostila");
            resultado2 = s.StartsWith("Java");
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);


            string s1 = "Arnaldo Madeira";
            string s2 = s1.Substring(8);
            string s3 = s1.Substring(0, 6);

            Console.WriteLine(s2);
            Console.WriteLine(s3);

            s1 = "    Arnaldo    Madeira  ";
            s2 = s1.Trim();
            Console.WriteLine(s2);

            DateTime dt = new DateTime(2010, 8, 27);

            //Acrescentando 140 dias
            dt.AddDays(140);

            //Subtraindo 2 anos
            dt.AddYears(-2);

            //Acrescentando 2 segundos
            dt.AddSeconds(20);

            Console.ReadKey();
        }
    }
}
