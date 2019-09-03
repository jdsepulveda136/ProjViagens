using System.Data.SqlClient;
using System.Data;


namespace ProjViagens
{
    internal class MyGetData
    {
        private string string_connection = "Data Source=89.154.2.41,62444;Initial Catalog=sepulveda_bdviagem;User ID=sepulveda;Password=123.abc;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DataTable BuscaDados(string ssql)
        {
            //criar uma conexão:
            SqlConnection C = new SqlConnection(string_connection);
            C.Open();
            //criar comando SQL para extrair os dados pretendidos:
            SqlCommand command = C.CreateCommand();
            command.CommandText = ssql;
            //trazer dados da tab. especif. p/ uma "tab." em memória:
            SqlDataAdapter da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);
            //desligar a conexão:
            C.Close();
            return dt;
        }
    }
}