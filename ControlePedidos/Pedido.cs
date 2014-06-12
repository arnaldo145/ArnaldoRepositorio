using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ControlePedidos
{
    class Pedido
    {
        public static string ConnectionString, DataAbertura;
        public static SqlCommand command;
        public static int Codigo, IdCliente, IdProduto, Quantidade, Opcao;

        static void Main(string[] args)
        {
            ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\arnal_000\Source\Repos\ArnaldoRepositorio\ControlePedidos\ArnaldoDB.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            do
            {
                Console.Clear();
                Opcao = MostrarMenu();
                switch (Opcao)
                {
                    default:
                        Console.Clear();
                        Console.WriteLine(" ----- ATENÇÃO ----- \n \nOpção informada é inválida! Verifique as opções e escolha uma opção válida!\nENTER para sair: ");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine(" ----- SAINDO ----- \n \nVocê está saindo do programa!\n \nAté Logo!\n \nENTER para sair: ");
                        Console.ReadKey();
                        break;

                    case 1:
                        Console.Clear();
                        Console.WriteLine(" ----- CADASTRO DE PEDIDOS ----- \n");
                        Console.Write("Informe a quantidade do produto: ");
                        Quantidade = int.Parse(Console.ReadLine());
                        Console.Write("Informe o código do produto: ");
                        IdProduto = int.Parse(Console.ReadLine());
                        Console.Write("Informe o código do cliente: ");
                        IdCliente = int.Parse(Console.ReadLine());
                        DataAbertura = DateTime.Now.ToShortDateString();
                        string insertPedido = String.Format(@"INSERT Pedido(Cliente_Id, Produto_Id, DataPedido, Quantidade) VALUES({0}, {1}, '{2}', {3})", IdCliente, IdProduto, DataAbertura, Quantidade);
                        command = new SqlCommand(insertPedido, sqlConnection);

                        try
                        {
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                                Console.WriteLine("\nSUCESSO! Pedido foi CADASTRADO no sistema\n");
                            else
                                Console.WriteLine("\nATENÇÃO:Pedido NÃO CADASTRADO no sistema\n");
                        }
                        catch (SqlException e)
                        {
                            Console.Write("\nERRO: {0}\n", e.Message.ToString());
                        }
                        command.Dispose();
                        Console.WriteLine("\nPressione ENTER para continuar: ");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine(" ----- EDITAR PEDIDOS ----- \n");
                        Console.Write("Informe o código do pedido: ");
                        Codigo = int.Parse(Console.ReadLine());
                        Console.Write("Informe a quantidade do produto: ");
                        Quantidade = int.Parse(Console.ReadLine());
                        Console.Write("Informe o código do produto: ");
                        IdProduto = int.Parse(Console.ReadLine());
                        Console.Write("Informe o código do cliente: ");
                        IdCliente = int.Parse(Console.ReadLine());
                        string updatePedido = String.Format(@"UPDATE Pedido SET Cliente_Id = {0}, Produto_Id = {1}, Quantidade = {2}, DataPedido = '{3}' WHERE Id = {4}", IdCliente, IdProduto, Quantidade, DateTime.Now.ToShortTimeString(), Codigo);
                        command = new SqlCommand(updatePedido, sqlConnection);
                        try
                        {
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                                Console.WriteLine("\nSUCESSO! Pedido foi ATUALIZADO no sistema\n");
                            else
                                Console.WriteLine("\nATENÇÃO:Pedido NÃO ATUALIZADO no sistema\n");
                        }
                        catch (SqlException e)
                        {
                            Console.Write("\nERRO: {0}\n", e.Message.ToString());
                        }
                        command.Dispose();
                        Console.WriteLine("\nPressione ENTER para continuar: ");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine(" ----- EXCLUIR PEDIDOS ----- \n");
                        Console.Write("Informe o código do pedido: ");
                        Codigo = int.Parse(Console.ReadLine());
                        string removePedido = String.Format(@"REMOVE Pedido WHERE Id = {0}", Codigo);
                        try
                        {
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                                Console.WriteLine("\nSUCESSO! Pedido foi REMOVIDO no sistema\n");
                            else
                                Console.WriteLine("\nATENÇÃO:Pedido NÃO REMOVIDO no sistema\n");
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
                        Console.WriteLine(" ----- LISTAR PEDIDOS ----- \n");
                        string listarPedidos = @"SELECT * FROM Pedido AS p INNER JOIN Cliente as c ON c.Id = p.Cliente_Id INNER JOIN Produto AS prod ON prod.Id = p.Produto_Id";
                        command = new SqlCommand(listarPedidos, sqlConnection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine("Código: {0}", reader["Id"]);
                            Console.WriteLine("Cliente: {0}", reader["PrimeiroNome"]);
                            Console.WriteLine("Produto: {0}", reader["Nome"]);
                            Console.WriteLine("Quantidade: {0}", reader["Quantidade"]);
                            Console.WriteLine("---------- ----------");

                        }
                        reader.Close();
                        command.Dispose();
                        Console.WriteLine("\nPressione ENTER para continuar: ");
                        Console.ReadKey();
                        break;
                }
            } while (Opcao != 5);

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
