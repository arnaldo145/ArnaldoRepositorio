﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVIII.ExerciciosSlide
{
    class ControleDeFluxo
    {
        public static void Main1()
        {
            Random gerador = new Random();

            //Aprovado-Reprovado   
            double nota = gerador.NextDouble();
            Console.WriteLine("Nota: {0:F1}", nota);
            if (nota > 0.7) {
                Console.WriteLine("Aluno foi aprovado");
            } else{
                Console.WriteLine("Aluno foi reprovado");
            }

            //Verifica Valor do Produto
            double valor = gerador.NextDouble();
            Console.WriteLine("\nPreço: R${0:F2}",valor);
            if (valor > 0.5) {
                Console.WriteLine("Preço é caro");
            } else {
                Console.WriteLine("Preço é caro");
            }

            //EscolheCaminho
            double caminho = gerador.NextDouble();
            Console.WriteLine("\nCaminho: {0:F2}", caminho);
            if (caminho > 0.5) {
                Console.WriteLine("Siga para direita");
            } else {
                Console.WriteLine("Siga para esquerda");
            }

            //EscolheRoupa
            double roupa = gerador.NextDouble();
            Console.WriteLine("\nRoupa: {0:F2}", roupa);
            if (caminho > 0.5) {
                Console.WriteLine("Vista uma camisa vermelha");
            } else {
                Console.WriteLine("Vista uma camisa azul");
            }

            //ADividioPorB
            int a = gerador.Next(1,100);
            int b = gerador.Next(1,100);

            if (a % b == 0) {
                Console.WriteLine("\n{0} é divisivel por {1}\n", a, b);
            } else {
                Console.WriteLine("\n{0} não é divisivel por {1}\n", a, b);
            }

            //InstruçõesRepetições
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("NDDigital Technologies {0}", i);
            }

            Console.WriteLine(" ");

            //Imprime100
            int z = 1;
            while (z <= 100)
            {
                Console.WriteLine("{0}", z);
                z++;
            }

            Console.WriteLine(" ");

            //Imprime100ExcetoMultiplo3
            z = 1;
            while (z <= 100)
            {
                if(z % 3 != 0){
                    Console.WriteLine("{0}", z);
                }                
                z++;
            }

            Console.WriteLine(" ");

            //DivideMaiorInteiro
            int valorMaximo = 2147483647;
            do
            {
                valorMaximo /= 2;
                Console.WriteLine(valorMaximo);
            } while (valorMaximo > 100);

            Console.WriteLine(" ");

            //GeradorDeIngressos
            int countIngressos = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    countIngressos++;
                    Console.Write("{0} ", countIngressos);
                }
                Console.WriteLine(" ");
            }

                Console.ReadKey();
        }
    }
}
