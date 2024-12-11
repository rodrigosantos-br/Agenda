using Microsoft.Data.SqlClient;
using AgendaDeCompromissos.Modelo;
using System.Data;

namespace AgendaDeCompromissos.DAL
{
    internal class CompromissoDAO
    {
        public string mensagem;

        public void AdicionarCompromisso(Compromisso compromisso)
        {
            SqlConnection con = Conexao.Conectar();
            string sql = @"INSERT INTO compromissos (Titulo, Datahora, Descricao)
                         VALUES (@Titulo, @Datahora, @Descricao)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Titulo", compromisso.Titulo);
            cmd.Parameters.AddWithValue("@Datahora", compromisso.DataHora);
            cmd.Parameters.AddWithValue("@Descricao", compromisso.Descricao);

            try
            {
                cmd.ExecuteNonQuery();
                this.mensagem = "Agendado com sucesso!";
            }
            catch (Exception)
            {
                this.mensagem = "Erro ao agendar";
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public DataTable ObterCompromissos()
        {
            DataTable tabela = new DataTable();
            SqlConnection con = Conexao.Conectar();
            string sql = @"SELECT Id, Titulo, DataHora, Descricao FROM compromissos";

            try
            {
                SqlCommand cmd = new SqlCommand (sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tabela);
            }
            catch
            {
                this.mensagem = "Erro ao obter comproomisso";
            }
            finally
            {
                Conexao.Desconectar();
            }
            return tabela;
        }

        public void AtualizarCompromisso(Compromisso compromisso)
        {
            SqlConnection con = Conexao.Conectar();
            string sql = @"UPDATE compromissos SET Titulo = @Titulo, DataHora = @DataHora, Descricao = @Descricao WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand (sql, con);
            cmd.Parameters.AddWithValue("@Id", compromisso.Id);
            cmd.Parameters.AddWithValue("@Titulo", compromisso.Titulo);
            cmd.Parameters.AddWithValue("@DataHora", compromisso.DataHora);
            cmd.Parameters.AddWithValue("@Descricao", compromisso.Descricao);

            try
            {
                cmd.ExecuteNonQuery();
                this.mensagem = "Agendamento atualizado com sucesso!";
            }
            catch
            {
                this.mensagem = "Erro ao atualizar o agendamento";
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public void ExcluirCompromisso(int id)
        {
            SqlConnection con = Conexao.Conectar();
            string sql = @"DELETE FROM compromissos WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                cmd.ExecuteNonQuery();
                this.mensagem = "Agendamento excluído com sucesso";
            }
            catch (Exception) 
            {
                this.mensagem = "Erro ao excluir o agendamento";
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}
