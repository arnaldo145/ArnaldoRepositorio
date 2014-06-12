using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ControlePedidos
{
    class Cliente
    {
        public static string ConnectionString, Nome, Sobrenome, Cidade, Estado, Cep, Cpf, Telefone;
        public static SqlCommand command;
        public static int Codigo;

        static void Main1(string[] args)
        {

            ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\aluno\Source\Repos\ArnaldoRepositorio\ControlePedidos\ArnaldoDB.mdf;Integrated Security=True";
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
                        Console.WriteLine(" ===== CADASTRO DE CLIENTE =====\n");
                        
                        Console.Write("Informe o primeiro nome: ");
                        Nome = Console.ReadLine();
                        Console.Write("Informe o sobrenome: ");
                        Sobrenome = Console.ReadLine();
                        Console.Write("Informe a cidade: ");
                        Cidade = Console.ReadLine();
                        Console.Write("Informe o estado: ");
                        Estado = Console.ReadLine();
                        Console.Write("Informe o CEP: ");
                        Cep = Console.ReadLine();
                        Console.Write("Informe o CPF: ");
                        Cpf = Console.ReadLine();
                        Console.Write("Informe o telefone: ");
                        Telefone = Console.ReadLine();

                        string insertCliente = String.Format("INSERT Cliente (PrimeiroNome, Sobrenome, Cidade, Estado, CEP, CPF, Telefone) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Nome, Sobrenome, Cidade, Estado, Cep, Cpf, Telefone);
                        command = new SqlCommand(insertCliente, sqlConnection);

                        try
                        {
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                                Console.WriteLine("\nSUCESSO! Cliente foi CADASTRADO no sistema\n");
                            else
                                Console.WriteLine("\nATENÇÃO: Cliente NÃO CADASTRADO no sistema\n");
                        }
                        catch (SqlException e)
                        {
                            Console.Write("\nERRO: {0}\n", e.Message.ToString());
                        }
                        command.Dispose();
                        Console.WriteLine("\nPressione ENTER: ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" ===== LISTAR =====\n");
                        command = new SqlCommand("SELECT * FROM Cliente", sqlConnection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine("Código: {0} - {1} {2}", reader["Id"], reader["PrimeiroNome"], reader["Sobrenome"]);
                            Console.WriteLine("Cidade: {0} - {1}", reader["Cidade"], reader["Estado"]);
                            Console.WriteLine("CEP: {0}\nCPF: {1} \nTelefone: {2}", reader["CEP"], reader["CPF"], reader["Telefone"]);
                            Console.WriteLine("---------- ----------");
                        }
                        reader.Close();
                        Console.WriteLine("\nPressione ENTER: ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(" ===== EDITAR =====\n");

                        Console.Write("Informe o código: ");
                        Codigo = int.Parse(Console.ReadLine());
                         Console.Write("Informe o primeiro nome: ");
                        Nome = Console.ReadLine();
                        Console.Write("Informe o sobrenome: ");
                        Sobrenome = Console.ReadLine();
                        Console.Write("Informe a cidade: ");
                        Cidade = Console.ReadLine();
                        Console.Write("Informe o estado: ");
                        Estado = Console.ReadLine();
                        Console.Write("Informe o CEP: ");
                        Cep = Console.ReadLine();
                        Console.Write("Informe o CPF: ");
                        Cpf = Console.ReadLine();
                        Console.Write("Informe o telefone: ");
                        Telefone = Console.ReadLine();

                        string updateCliente = String.Format("UPDATE Cliente SET PrimeiroNome = '{0}', Sobrenome = '{1}', Cidade = '{2}', Estado = '{3}', CEP = '{4}', CPF = '{5}', Telefone = '{6}' WHERE Id = {7}", Nome, Sobrenome, Cidade, Estado, Cep, Cpf, Telefone, Codigo);
                        command = new SqlCommand(updateCliente, sqlConnection);
                        try
                        {
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                                Console.WriteLine("\nSUCESSO! Cliente com dados atualizados no sistema\n");
                            else
                                Console.WriteLine("\nATENÇÃO: Cliente com dados não atualizados no sistema\n");
                        }
                        catch (SqlException e)
                        {
                            Console.Write("\nERRO: {0}\n", e.Message.ToString());
                        }
                        command.Dispose();
                        Console.WriteLine("\nPressione ENTER: ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(" ===== EXCLUIR =====\n");
                        Console.Write("Informe o código: ");
                        Codigo = int.Parse(Console.ReadLine());
                        string removeCliente = String.Format("DELETE FROM Cliente WHERE Id = {0}", Codigo);
                        command = new SqlCommand(removeCliente, sqlConnection);
                        
                        try
                        {
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                                Console.WriteLine("\nSUCESSO! Cliente removido do sistema\n");
                            else
                                Console.WriteLine("\nATENÇÃO: Cliente não foi removido do sistema\n");
                        }
                        catch (SqlException e)
                        {
                            Console.Write("\nERRO: {0}\n", e.Message.ToString());
                        }
                        command.Dispose();
                        Console.WriteLine("\nPressione ENTER: ");
                        Console.ReadKey();
                        break;
                    case 5:                        
                        Console.Clear();
                        Console.WriteLine(" ===== SAINDO ===== \n");
                        Console.Write("Até Logo \n \nPressione ENTER: ");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(" ===== OPÇÃO INVÁLIDA =====\n");
                        Console.Write("ATENÇÃO! Opção informada é inválida! \n \nENTER para continuar: ");
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
