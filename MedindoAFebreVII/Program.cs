using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreVII
{
    class Program
    {
//        13) Implemente um algoritmo que armazene a idade, nome, sexo, altura, se é adulto ou não. Esses vetores devem ter 50 posições
        //cada um. O algoritmo deve ter métodos ou funções para inicializar seus vetores com os dados, os valores de idade, altura, sexo
        //e se é adulto ou não, podem ser gerados aletoriamente.
//- A porcentagem dos que são adultos e dos que não são;  ok
//- A porcentagem do sexo masculino e feminino; ok
//- A porcentagem dos mais altos que 1,70m; ok
//- Listar todos da seguinte maneira:  Nome: Thiago Sartor, Idade: 23, Sexo: ‘M’, Adulto: true ok
//- Listar os 10 mais velhos;
//- Listar os 5 mais novos;
//- Listar a pessoa mais alta; ok
//- Listar a pessoa mais baixa; ok

        static int[] Idades = new int[50];
        static string[] Nomes = new string[50];
        static char[] Sexo = new char[50];
        static double[] Altura = new double[50];
        static bool[] IsAdulto = new bool[50];
        static Random Gerador = new Random();

        static void Main(string[] args)
        {
            AtribuirValores();
            ListarTodos();
            CalcularPorcentagens();
            OrganizarIdades();
            Console.ReadKey();
        }

        static void AtribuirSexo()
        {
            for (int i = 0; i < Sexo.Length; i++)
            {
                int opcao = Gerador.Next(1, 3);
                if (opcao == 1)
                {
                    Sexo[i] = 'M';
                }
                if (opcao == 2)
                {
                    Sexo[i] = 'F';
                }
            }
        }

        static void AtribuirIdade()
        {
            for (int i = 0; i < Idades.Length; i++)
            {
                Idades[i] = Gerador.Next(0, 100);
                if(Idades[i] < 18){
                    IsAdulto[i] = false;
                } else {
                    IsAdulto[i] = true;
                }
            }
        }

        static void AtribuirNome()
        {
            for (int i = 0; i < Nomes.Length; i++)
            {
                Nomes[i] = "TESTE" + i;
            }
        }

        static void AtribuirAltura()
        {
            for (int i = 0; i < Altura.Length; i++)
            {
                int metros = Gerador.Next(1, 2);
                double centimetros = Gerador.NextDouble();
                Altura[i] = metros + centimetros;
            }
        }

        static void AtribuirValores()
        {
            Console.WriteLine("CONTROLADOR - Atribuindo valores!");
            AtribuirAltura();
            AtribuirIdade();
            AtribuirNome();
            AtribuirAltura();
            AtribuirSexo();
            Console.WriteLine("CONTROLADOR - Valores atribuidos!");
            Console.WriteLine("Aperte ENTER para continuar: ");
            Console.ReadKey();
            Console.Clear();
        }

        static int ContandoAdultos()
        {
            int countAdultos = 0;
            for (int i = 0; i < IsAdulto.Length; i++)
            {
                if (IsAdulto[i] == true)
                {
                    countAdultos++;
                }       
            }
            return countAdultos;
        }

        static void ListarTodos()
        {
            double maiorAltura = 0;
            double menorAltura = Altura[0];

            for (int i = 0; i < 50; i++)
            {                
                Console.Write("Nome: {0} - Idade: {1} - Sexo: '{2}' - Adulto: {3} - Altura: {4:F2}\n", Nomes[i], Idades[i], Sexo[i], IsAdulto[i], Altura[i]);                

                if (maiorAltura < Altura[i])                
                    maiorAltura = Altura[i];                

                if (menorAltura > Altura[i])              
                    menorAltura = Altura[i];  
            }
            Console.WriteLine("\n \nMaior Altura: {0:F2} \nMenor Altura: {1:F2}", maiorAltura, menorAltura);
        }

        static void CalcularPorcentagens()
        {
            int countAdultos = 0;
            int countMenores = 0;
            int countMasc = 0;
            int countFem = 0;
            int countAltura = 0;

            for (int i = 0; i < 50; i++)
            {
                if(IsAdulto[i] == true){
                    countAdultos++;
                }
                else
                {
                    countMenores++;
                }

                if (Sexo[i] == 'M')
                {
                    countMasc++;
                }
                if (Sexo[i] == 'F')
                {
                    countFem++;
                }

                if (Altura[i] > 1.70)
                {
                    countAltura++;
                }
            }
            double porcentagemAdultos = (countAdultos * 100) / 50;
            double porcentagemMenores = (countMenores * 100) / 50;
            double porcentagemMasculino = (countMasc * 100) / 50;
            double porcentagemFeminino = (countFem * 100) / 50;
            double porcentagemPessoasAltas = (countAltura * 100) / 50;
            Console.WriteLine("Adultos: {0}% - Menores de Idade: {1}%", porcentagemAdultos, porcentagemMenores);
            Console.WriteLine("Sexo Masculino: {0}% - Sexo Feminino: {1}%", porcentagemMasculino, porcentagemFeminino);
            Console.WriteLine("Maiores de 1.70 metros: {0}%", porcentagemPessoasAltas);
        }

        static void OrganizarIdades()
        {
            int maisVelho = 0;

            for (int i = 0; i < Idades.Length; i++)
            {
                if (maisVelho < Idades[i])
                {
                    maisVelho = Idades[i];
                }
            }
            int[] maisVelhos = new int[10];
            maisVelhos[0] = maisVelho;

            for (int i = 1; i < maisVelhos.Length; i++)
            {
                maisVelho = 0;
                for (int j = 0; j < Idades.Length; j++)
                {
                    if(Idades[j] > maisVelho && Idades[j] < maisVelhos[i-1]){
                        maisVelho = Idades[j];
                    }
                }
                maisVelhos[i] = maisVelho;
            }

            Console.Write("Mais Velhos: ");
            for (int i = 0; i < maisVelhos.Length; i++)
            {
                Console.Write("{0} ", maisVelhos[i]);
            }
           
        }
    }
}
