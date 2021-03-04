using System;
using System.Data;
using System.Data.SqlClient;
namespace EfaUtils
{
    /// <summary>
    /// Classe com membros para ligação a base de dados
    /// </summary>
    class Conecta
    {
        public DataTable BuscarDados(string strConnection, string strSQL)
            {
                //criar uma conexão:
                SqlConnection C = new SqlConnection(strConnection);
                C.Open();
                //criar comando SQL para extrair os dados pretendidos:
                SqlCommand command = C.CreateCommand();
                command.CommandText = strSQL;

                //trazer os dados da tabela especificada para uma "tabela" em memória:
                SqlDataAdapter da = new SqlDataAdapter(command);
                var dt = new DataTable();
                da.Fill(dt);

                //desligar a conexão:
                C.Close();
                return dt;
            }
        
    }

}


