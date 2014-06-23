using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ArrayList
{
    class Program
    {

        public static ArrayList telefones = new ArrayList();
        public static ArrayList nomes = new ArrayList();
        static void MainI(string[] args)
        {
            int opc = 0;
            int pos = 0;

            do
            {
                Console.Clear();
                opc = mostrarMenu();

                switch (opc)
                {
                    default:
                        Console.Clear();
                        Console.WriteLine(" ===== OPÇÃO INVÁLIDA ===== \n");
                        Console.WriteLine("Opção informada é inválida! Informe uma opção válida.\n \nENTER para continuar: ");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine(" ===== SAINDO ===== \n");
                        Console.WriteLine("Até Logo!");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine(" ===== CONTATOS ===== \n");
                        Console.WriteLine("\nTotal de contatos: {0}", nomes.Count);

                        if (nomes.Count < 0)
                            Console.WriteLine("\nATENÇÃO! Nenhum contato cadastrado!");
                        else
                        {
                            for (int i = 0; i < nomes.Count; i++)
                                Console.WriteLine("\nNome: {0} - Telefone {1} - Pos: {2}\n", nomes[i], telefones[i], i);
                        }

                        Console.Write("\nENTER para retornar ao MENU INICIAL: ");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine(" ===== APAGAR ===== \n");
                        Console.Write("Informe a posição: ");
                        pos = int.Parse(Console.ReadLine());

                        if (pos > nomes.Count || pos < 0)
                            Console.WriteLine("\nATENÇÃO! Opção informada é inválida!");
                        else
                        {
                            nomes.RemoveAt(pos);
                            telefones.RemoveAt(pos);
                            Console.WriteLine("\nSUCESSO! Contato foi removido!\n");
                        }

                        Console.Write("ENTER para retornar ao MENU INICIAL: ");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine(" ===== EDITAR =====\n");
                        Console.Write("Informe a posição: ");
                        pos = int.Parse(Console.ReadLine());
                        if (pos > nomes.Count || pos < 0)
                            Console.WriteLine("\nATENÇÃO! Opção informada é inválida!");
                        else
                        {
                            Console.Write("Informe o nome: ");
                            string nomeEdita = Console.ReadLine();
                            Console.Write("Informe o telefone: ");
                            string telefoneEdita = Console.ReadLine();
                            nomes[pos] = nomeEdita;
                            telefones[pos] = telefoneEdita;
                            Console.WriteLine("\nSUCESSO! Contato com dados atualizados!\n");
                        }
                        Console.WriteLine("ENTER para retornar ao MENU INICIAL:");
                        Console.ReadKey();
                        break;

                    case 1:
                        Console.Clear();
                        Console.WriteLine(" ===== CADASTRO ===== \n");

                        Console.Write("Informe o nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Informe o telefone: ");
                        string telefone = Console.ReadLine();

                        nomes.Add(nome);
                        telefones.Add(telefone);

                        Console.WriteLine("\nCadastro realizado com sucesso! \n \nENTER para retornar ao MENU INICIAL:");
                        Console.ReadKey();
                        break;
                }
            } while (opc != 5);

            Console.WriteLine("\nENTER para sair: ");
            Console.ReadKey();
        }

        public static int mostrarMenu()
        {
            Console.WriteLine(" ===== MENU =====\n \n1 - Cadastro \n2 - Editar \n3 - Apagar \n4 - Mostrar Todos \n5 - Sair");
            Console.Write("\nInforme a opção desejada: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
