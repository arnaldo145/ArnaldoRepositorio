using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ControlePedidos
{
    class Produto
    {
        public static string ConnectionString;
        public static SqlCommand command;
        public static int Codigo;
        public static String Nome, Unidade;
        public static decimal Valor;

        static void Main(string[] args)
        {
            ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\arnal_000\Source\Repos\ArnaldoRepositorio\ControlePedidos\ArnaldoDB.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            int opcao = 0;
            do
            {
                Console.Clear();
                opcao = MostrarMenu();
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("----- CADASTRO DE PRODUTOS ----- \n");

                        Console.Write("Informe o nome: ");
                        Nome = Console.ReadLine();
                        Console.Write("Informe a unidade: ");
                        Unidade = Console.ReadLine();
                        Console.Write("Informe o valor: ");
                        String valor = Console.ReadLine();
                        Valor = Decimal.Parse(valor.Replace(",", "."));
                        string insertProduto = String.Format("INSERT Produto(Nome, Unidade, Valor) VALUES('{0}','{1}','{2}')", Nome, Unidade, Valor);
                        command = new SqlCommand(insertProduto, sqlConnection);

                        try
                        {
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                                Console.WriteLine("\nSUCESSO! Produto foi CADASTRADO no sistema\n");
                            else
                                Console.WriteLine("\nATENÇÃO:Produto NÃO CADASTRADO no sistema\n");
                        }
                        catch (SqlException e)
                        {
                            Console.Write("\nERRO: {0}\n", e.Message.ToString());
                        }
                        command.Dispose();
                        Console.WriteLine("\nPressione ENTER para continuar: ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("----- LISTAR PRODUTOS ----- \n");
                        command = new SqlCommand("SELECT * FROM Produto", sqlConnection);
                        SqlDataReader reader = command.ExecuteReader();
                        while(reader.Read())
                        {
                            Console.WriteLine("Código: {0} - {1} \nUnidade: {2} \nValor: {3}", reader["Id"], reader["Nome"], reader["Unidade"], reader["Valor"]);
                            Console.WriteLine("--------- ---------");
                        }
                        reader.Close();
                        command.Dispose();

                        Console.WriteLine("\nPressione ENTER para continuar: ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("----- EDITAR PRODUTOS ----- \n");

                        Console.WriteLine("Informe o código: ");
                        Codigo = int.Parse(Console.ReadLine());
                        Console.Write("Informe o nome: ");
                        Nome = Console.ReadLine();
                        Console.Write("Informe a unidade: ");
                        Unidade = Console.ReadLine();
                        Console.Write("Informe o valor: ");
                        valor = Console.ReadLine();
                        Valor = Decimal.Parse(valor.Replace(",", "."));
                        string updateProduto = String.Format("UPDATE Produto SET Nome = '{0}', Unidade = '{1}', Valor = {2} WHERE Id = {3}", Nome, Unidade, Valor, Codigo);
                        command = new SqlCommand(updateProduto, sqlConnection);
                        try
                        {
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                                Console.WriteLine("\nSUCESSO! Produto foi ATUALIZADO no sistema\n");
                            else
                                Console.WriteLine("\nATENÇÃO:Produto NÃO ATUALIZADO no sistema\n");
                        }
                        catch (SqlException e)
                        {
                            Console.Write("\nERRO: {0}\n", e.Message.ToString());
                        }
                        command.Dispose();
                        Console.WriteLine("\nAperte ENTER para continuar: ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("----- REMOVER PRODUTOS ----- \n");
                        Console.WriteLine("Informe o código: ");
                        Codigo = int.Parse(Console.ReadLine());
                        string removeCliente = String.Format("DELETE FROM Produto WHERE Id = {0}", Codigo);
                        command = new SqlCommand(removeCliente, sqlConnection);
                        
                        try
                        {
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                                Console.WriteLine("\nSUCESSO! Produto removido do sistema\n");
                            else
                                Console.WriteLine("\nATENÇÃO: Produto não foi removido do sistema\n");
                        }
                        catch (SqlException e)
                        {
                            Console.Write("\nERRO: {0}\n", e.Message.ToString());
                        }
                        command.Dispose();
                        Console.WriteLine("\nPressione ENTER para continuar: ");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("----- SAINDO ----- \n");
                        Console.WriteLine("\nPressione ENTER para continuar: ");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("----- ATENÇÃO ----- \n");
                        Console.WriteLine("Opção Inválida! Informe uma opção válida! \nPressione ENTER para continuar: ");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 5);
            sqlConnection.Close();
        }

        public static int MostrarMenu()
        {
            Console.WriteLine(" ===== MENU ===== \n");
            Console.WriteLine(" 1 - Cadastrar \n 2 - Listar \n 3 - Editar \n 4 - Remover \n 5 - Sair");
            Console.Write("\nInforme a sua opção: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
