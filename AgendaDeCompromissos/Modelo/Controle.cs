using AgendaDeCompromissos.DAL;
using System.Data;

namespace AgendaDeCompromissos.Modelo
{
    internal class Controle
    {
        List<string> mensagem;

        public void AdicionarCompromisso(string titulo, DateTime dataHora, string descricao)
        {
            // Validação do compromisso
            Validacao validacao = new Validacao();
            this.mensagem = validacao.ValidarCompromisso(titulo, dataHora, descricao);

            if (mensagem.Equals("") || mensagem.Count == 0) 
            {
                Compromisso compromisso = new Compromisso
                {
                    Titulo = titulo,
                    DataHora = dataHora,
                    Descricao = descricao
                };

                // Criando uma instância do DAO e chamando o método para adicionar
                CompromissoDAO compromissoDao = new CompromissoDAO();
                compromissoDao.AdicionarCompromisso(compromisso);
                MessageBox.Show("Agendado com sucesso!");
            }
            else
            {
                // Exibir mensagens de erro de validação, caso existam
                foreach (var msg in mensagem)
                {
                    MessageBox.Show(msg);
                }
            }
        }

        public List<Compromisso> ObterCompromissos()
        {
            CompromissoDAO compromissoDao = new CompromissoDAO();
            DataTable tabelaCompromissos = compromissoDao.ObterCompromissos();  

            List<Compromisso> compromissos = new List<Compromisso>();

            foreach (DataRow row in tabelaCompromissos.Rows)
            {
                Compromisso compromisso = new Compromisso
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Titulo = row["Titulo"].ToString(),
                    DataHora = Convert.ToDateTime(row["DataHora"]),
                    Descricao = row["Descricao"].ToString()
                };

                compromissos.Add(compromisso);
            }

            return compromissos;
        }

        public void EditarCompromisso(Compromisso compromisso)
        {
            // Validação do compromisso
            Validacao validacao = new Validacao();
            this.mensagem = validacao.ValidarCompromisso(compromisso.Titulo, compromisso.DataHora, compromisso.Descricao);

            if (mensagem.Equals("") || mensagem.Count == 0)
            {
                CompromissoDAO compromissoDao = new CompromissoDAO();
                compromissoDao.AtualizarCompromisso(compromisso);
            }
            else
            {
                foreach (var msg in mensagem)
                {
                    MessageBox.Show(msg);
                }
            }
        }
        
        public void ExcluirCompromisso(int id)
        {
            CompromissoDAO compromissoDao = new CompromissoDAO();
            compromissoDao.ExcluirCompromisso(id);
        }

        public void LimparCampos(Control container)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Clear(); // Limpa o texto
                }
                else if (ctrl is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now; // Restaura para a data/hora atual
                }
                else if (ctrl.HasChildren)
                {
                    LimparCampos(ctrl); // Chamado recursivamente para sub-controles
                }
            }
        }
    }
}
