using AgendaDeCompromissos.Modelo;

namespace AgendaDeCompromissos.Apresentacao
{
    public partial class fmrAgenda : Form
    {
        private readonly Controle controle;
        public fmrAgenda()
        {
            InitializeComponent();
            controle = new Controle();
            // Associa o evento CellClick ao método correspondente
            dgvCompromissos.CellClick += dgvCompromissos_CellClick;
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            CarregarCompromissos();
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = controle.ObterCompromissos();

            // Limpa o DataGridView e carrega novamente os compromissos
            dgvCompromissos.DataSource = null;
            // Alterar os nomes exibidos no cabeçalho das colunas
            dgvCompromissos.DataSource = compromissos;
            dgvCompromissos.Columns["Titulo"].HeaderText = "Título";
            dgvCompromissos.Columns["DataHora"].HeaderText = "Data do Compromisso";
            dgvCompromissos.Columns["Descricao"].HeaderText = "Descrição Detalhada";

            // Oculta a coluna "Id" (caso necessário)
            if (dgvCompromissos.Columns.Contains("Id"))
            {
                dgvCompromissos.Columns["Id"].Visible = false;
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto do MaskedTextBox para DateTime
            if (DateTime.TryParse(mtbDataHora.Text, out DateTime dataHora))
            {
                // Adiciona o novo compromisso
                controle.AdicionarCompromisso(txbTitulo.Text, dataHora, txbDescricao.Text);

                // Limpa e recarrega os compromissos
                CarregarCompromissos();

                controle.LimparCampos(gpbAdicionarOuEditarCompromisso);
            }
            else
            {
                MessageBox.Show("Data e hora inválidas. Por favor, insira um valor válido.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCompromissos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvCompromissos.CurrentRow.Cells["Id"].Value);
                string titulo = txbTitulo.Text.Trim();
                string descricao = txbDescricao.Text.Trim();
                string dataHoraTexto = mtbDataHora.Text.Trim();
                DateTime dataHora;

                if (!DateTime.TryParse(dataHoraTexto, out dataHora))
                {
                    return;
                }

                // Criação do compromisso atualizado
                Compromisso compromisso = new Compromisso
                {
                    Id = id,
                    Titulo = titulo,
                    DataHora = dataHora,
                    Descricao = descricao
                };

                controle.EditarCompromisso(compromisso);
                controle.LimparCampos(gpbAdicionarOuEditarCompromisso);
                CarregarCompromissos();
            }
            else
            {
                MessageBox.Show("Selecione um compromisso para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCompromissos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvCompromissos.CurrentRow.Cells["Id"].Value);

                DialogResult resultado = MessageBox.Show(
                    "Deseja realmente excluir este compromisso?",
                    "Confirmação de exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    controle.ExcluirCompromisso(id);
                    CarregarCompromissos();
                    controle.LimparCampos(gpbAdicionarOuEditarCompromisso);
                }
            }
        }

        private void dgvCompromissos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var compromisso = dgvCompromissos.Rows[e.RowIndex].DataBoundItem as Compromisso;

                if (compromisso != null)
                {
                    txbTitulo.Text = compromisso.Titulo;
                    mtbDataHora.Text = compromisso.DataHora.ToString("dd/MM/yyyy HH:mm");
                    txbDescricao.Text = compromisso.Descricao;
                }
                else
                {
                    MessageBox.Show("Erro ao carregar o compromisso selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            controle.LimparCampos(gpbAdicionarOuEditarCompromisso);
        }
    }
}
