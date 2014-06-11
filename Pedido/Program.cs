using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pedido
{
    class Program
    {
        public static string ConnectionString;
        static void Main(string[] args)
        {
            ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\aluno\Source\Repos\ArnaldoRepositorio\UnidadeXII\ArnaldoDB.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            /*SqlCommand command = new SqlCommand("Select * from Produto", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read()){
                Console.WriteLine(reader["Nome"]);
            }*/

            /*Console.Write("Digite o ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            string sqlUpdate = String.Format("UPDATE Produto SET Nome = '{0}' where Id = {1}",nome, id);
            SqlCommand command = new SqlCommand(sqlUpdate, sqlConnection);
            try
            {
                int i = command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine("\nERRO: {0}", e.Message.ToString());
            }*/

            /*Console.Write("Digite o ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            string sqlUpdate = String.Format("DELETE FROM Produto WHERE Id = {0}", id);
            SqlCommand command = new SqlCommand(sqlUpdate, sqlConnection);
            try
            {
                int i = command.ExecuteNonQuery();
                if(i>0)
                    Console.WriteLine("\nProduto deletado com sucesso!");
                else
                    Console.WriteLine("\nProduto não encontrado!");
            } catch (SqlException e) {
                Console.WriteLine("\nERRO: {0}", e.Message.ToString());
            }

            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a unidade do produto: ");
            string unidade = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            decimal valor = decimal.Parse(Console.ReadLine());
            string sqlUpdate = String.Format("INSERT Produto(Nome, Valor, Unidade) VALUES('{0}', {1}, '{2}')", nome, valor, unidade);
            SqlCommand command = new SqlCommand(sqlUpdate, sqlConnection);
            try
            {
                int i = command.ExecuteNonQuery();
                if (i > 0)
                    Console.WriteLine("\nProduto inserido com sucesso!");
                else
                    Console.WriteLine("\nERRO: NÃO FOI POSSÍVEL ADICIONAR PRODUTO!");
            }
            catch (SqlException e)
            {
                Console.WriteLine("\nERRO: {0}", e.Message.ToString());
            }*/



            sqlConnection.Close();
            Console.Write("\nENTER para sair: ");
            Console.ReadKey();
        }
    }
}
