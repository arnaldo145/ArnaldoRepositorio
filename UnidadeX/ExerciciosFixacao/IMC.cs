using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeX.ExerciciosFixacao
{
    class IMC
    {
        //Na pasta funcoes-ou-metodos, crie um arquivo chamado IMC.cs. Implemente um programa
        //em C# definindo um método que realize o cálculo do índice de massa corporal e outro
        //que determina a situação da pessoa a partir desse índice.
        public static void Main1()
        {
            Console.WriteLine(" ===== IMC =====\n");
            Console.Write("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Informe o peso: ");
            double peso = double.Parse(Console.ReadLine());
            double imc = CalcularIMC(altura, peso);
            Console.WriteLine("\n ===== RESULTADO ===== \n \nIMC: {0:F2} \nSituação: {1}", imc, VerificarSituacao(imc));
            Console.ReadKey();
        }

        static double CalcularIMC(double alturaUsuario, double pesoUsuario)
        {
            return pesoUsuario / Math.Pow(alturaUsuario, 2);
        }

        static string VerificarSituacao(double imcUsuario)
        {
            if (imcUsuario < 17)
                return "Muito abaixo do peso";
            if (imcUsuario >= 17 && imcUsuario <= 18.49)
                return "Abaixo do peso";
            if (imcUsuario >= 18.5 && imcUsuario <= 24.99)
                return "Peso normal";
            if (imcUsuario >= 25 && imcUsuario <= 29.99)
                return "Acima do peso";
            if (imcUsuario >= 30 && imcUsuario <= 34.99)
                return "Obesidade I";
            if (imcUsuario >= 35 && imcUsuario <= 39.99)
                return "Obesidade II (severa)";
            if (imcUsuario >= 40)
                return "Obesidade III (mórbida)";
            return null;
        }
    }
}
