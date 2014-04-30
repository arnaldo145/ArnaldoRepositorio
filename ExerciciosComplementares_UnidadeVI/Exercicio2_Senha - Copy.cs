using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares_UnidadeVI
{
    class Exercicio2_Senha
    {
        //2) Escreva um programa que verifique a validade de uma senha fornecida pelo usuário. A senha válida
        //é o número NomeUsuário123. Devem ser impressas as seguintes mensagens: 
        //ACESSO PERMITIDO caso a senha seja válida. 
        //ACESSO NEGADO caso a senha seja inválida.
        //Lembrando que essa senha deve ser atualizada em 15 em 15 dias, por segurança.

        static string Senha = "NomeUsuario123";
        static int ContadorDias;

        static void Main2(string[] args)
        {
            ContadorDias = 15;
            int opcao = 0;

            do{
                Console.Clear();                

                if (ContadorDias == 0)
                {
                    Console.WriteLine("\nATENÇÃO: Senha deve ser alterada! \n");
                    alterarSenha();
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\nVocê deve alterar a senha em {0} dias \n", (ContadorDias - 1));
                }
                else
                {
                    Console.WriteLine("\nVocê deve alterar a senha em {0} dias \n", ContadorDias);
                }

                mostrarMenu();

                Console.Write("\nInforme a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        entrarSistema();
                        break;

                    case 2:
                        alterarSenha();
                        break;

                    case 3:
                        Console.WriteLine("\nATÉ LOGO!");
                        break;

                    default:
                        Console.WriteLine("\nInforme uma opção válida!");
                        break;
                }

                ContadorDias -= 1;
            } while (opcao != 3);           

            Console.ReadKey();
        }

        static void mostrarMenu()
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1 - ENTRAR NO SISTEMA \n2 - ALTERAR SENHA \n3 - SAIR");
        }

        static void entrarSistema()
        {
            Console.Write("\nInforme a senha: ");
            string senhaInformada = Console.ReadLine();
            if (senhaInformada == Senha)
            {
                Console.WriteLine("\nACESSO PERMITIDO!");
            }
            else
            {
                Console.WriteLine("\nACESSO NEGATIVO!");
            }
            Console.ReadKey();
        }

        static void alterarSenha()
        {
            Console.WriteLine("Informe a nova senha: ");
            string senhaInformada = Console.ReadLine();
            Console.WriteLine("Informe a senha atual para concluir alterações: ");
            string senhaAtual = Console.ReadLine();

            if (senhaAtual == Senha)
            {
                Senha = senhaInformada;
                ContadorDias = 16;
                Console.WriteLine("\nSENHA ALTERADA!");
            }
            else
            {
                Console.WriteLine("\nATENÇÃO: Não foi possível alterar a senha!");
            }
            Console.ReadKey();
        }
    }
}
