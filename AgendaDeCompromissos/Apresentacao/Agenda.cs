using AgendaDeCompromissos.Modelo;
using System.Windows.Forms;

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
            // Adiciona o novo compromisso
            controle.AdicionarCompromisso(txbTitulo.Text, dtpDataHora.Value, txbDescricao.Text);

            // Limpa e recarrega os compromissos
            CarregarCompromissos();

            controle.LimparCampos(gpbAdicionarOuEditarCompromisso);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCompromissos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvCompromissos.CurrentRow.Cells["Id"].Value);
                string titulo = txbTitulo.Text;
                DateTime dataHora = dtpDataHora.Value;
                string descricao = txbDescricao.Text;

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
            // Verifica se a linha clicada é válida
            if (e.RowIndex >= 0 && dgvCompromissos.Rows[e.RowIndex].DataBoundItem is Compromisso compromisso)
            {
                // Preenche os campos com os dados do compromisso selecionado
                txbTitulo.Text = compromisso.Titulo;
                dtpDataHora.Value = compromisso.DataHora;
                txbDescricao.Text = compromisso.Descricao;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            controle.LimparCampos(gpbAdicionarOuEditarCompromisso);
        }
    }
}
