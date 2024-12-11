using Microsoft.Data.SqlClient;
using System.Configuration;

namespace AgendaDeCompromissos.DAL
{
    internal class Conexao
    {
        private static SqlConnection _conexao;
        private static string _conexaoString = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

        public static SqlConnection Conectar()
        {
            if(_conexao == null)
                _conexao = new SqlConnection(_conexaoString);
            
            if(_conexao.State == System.Data.ConnectionState.Closed)
                _conexao.Open();

            return _conexao;
        }

        public static void Desconectar()
        {
            if (_conexao == null && _conexao.State == System.Data.ConnectionState.Open)
                _conexao.Close();
        }
    }
}
