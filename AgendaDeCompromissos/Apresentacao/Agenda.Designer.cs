using System.Windows.Forms;

namespace AgendaDeCompromissos.Apresentacao
{
    partial class fmrAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCompromissos = new DataGridView();
            gpbAdicionarOuEditarCompromisso = new GroupBox();
            btnLimpar = new Button();
            dtpDataHora = new DateTimePicker();
            btnEditar = new Button();
            txbTitulo = new TextBox();
            lblTitulo = new Label();
            btnAgendar = new Button();
            lblDataHora = new Label();
            txbDescricao = new TextBox();
            lblDescricao = new Label();
            btnExcluir = new Button();
            gpbCompromissos = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvCompromissos).BeginInit();
            gpbAdicionarOuEditarCompromisso.SuspendLayout();
            gpbCompromissos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCompromissos
            // 
            dgvCompromissos.AllowUserToAddRows = false;
            dgvCompromissos.AllowUserToDeleteRows = false;
            dgvCompromissos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompromissos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCompromissos.Location = new Point(50, 53);
            dgvCompromissos.Name = "dgvCompromissos";
            dgvCompromissos.ReadOnly = true;
            dgvCompromissos.RowHeadersVisible = false;
            dgvCompromissos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompromissos.Size = new Size(558, 410);
            dgvCompromissos.TabIndex = 7;
            dgvCompromissos.TabStop = false;
            // 
            // gpbAdicionarOuEditarCompromisso
            // 
            gpbAdicionarOuEditarCompromisso.Controls.Add(btnLimpar);
            gpbAdicionarOuEditarCompromisso.Controls.Add(dtpDataHora);
            gpbAdicionarOuEditarCompromisso.Controls.Add(btnEditar);
            gpbAdicionarOuEditarCompromisso.Controls.Add(txbTitulo);
            gpbAdicionarOuEditarCompromisso.Controls.Add(lblTitulo);
            gpbAdicionarOuEditarCompromisso.Controls.Add(btnAgendar);
            gpbAdicionarOuEditarCompromisso.Controls.Add(lblDataHora);
            gpbAdicionarOuEditarCompromisso.Controls.Add(txbDescricao);
            gpbAdicionarOuEditarCompromisso.Controls.Add(lblDescricao);
            gpbAdicionarOuEditarCompromisso.Location = new Point(58, 34);
            gpbAdicionarOuEditarCompromisso.Name = "gpbAdicionarOuEditarCompromisso";
            gpbAdicionarOuEditarCompromisso.Size = new Size(233, 403);
            gpbAdicionarOuEditarCompromisso.TabIndex = 10;
            gpbAdicionarOuEditarCompromisso.TabStop = false;
            gpbAdicionarOuEditarCompromisso.Text = "Adicionar ou Editar Compromisso";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(77, 359);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dtpDataHora
            // 
            dtpDataHora.CustomFormat = "dd/MM/yyyy      HH:mm";
            dtpDataHora.Format = DateTimePickerFormat.Custom;
            dtpDataHora.Location = new Point(34, 97);
            dtpDataHora.MinDate = new DateTime(2024, 12, 10, 0, 0, 0, 0);
            dtpDataHora.Name = "dtpDataHora";
            dtpDataHora.Size = new Size(160, 23);
            dtpDataHora.TabIndex = 2;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(119, 330);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txbTitulo
            // 
            txbTitulo.Location = new Point(34, 37);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(160, 23);
            txbTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(34, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(34, 330);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(75, 23);
            btnAgendar.TabIndex = 4;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // lblDataHora
            // 
            lblDataHora.AutoSize = true;
            lblDataHora.Location = new Point(34, 79);
            lblDataHora.Name = "lblDataHora";
            lblDataHora.Size = new Size(69, 15);
            lblDataHora.TabIndex = 1;
            lblDataHora.Text = "Data e Hora";
            // 
            // txbDescricao
            // 
            txbDescricao.Location = new Point(34, 157);
            txbDescricao.Multiline = true;
            txbDescricao.Name = "txbDescricao";
            txbDescricao.Size = new Size(160, 136);
            txbDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(34, 139);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(50, 469);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // gpbCompromissos
            // 
            gpbCompromissos.Controls.Add(dgvCompromissos);
            gpbCompromissos.Controls.Add(btnExcluir);
            gpbCompromissos.Location = new Point(372, 34);
            gpbCompromissos.Name = "gpbCompromissos";
            gpbCompromissos.Size = new Size(663, 529);
            gpbCompromissos.TabIndex = 13;
            gpbCompromissos.TabStop = false;
            gpbCompromissos.Text = "Compromissos";
            // 
            // fmrAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 594);
            Controls.Add(gpbCompromissos);
            Controls.Add(gpbAdicionarOuEditarCompromisso);
            Name = "fmrAgenda";
            Text = "Agenda";
            Load += Agenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompromissos).EndInit();
            gpbAdicionarOuEditarCompromisso.ResumeLayout(false);
            gpbAdicionarOuEditarCompromisso.PerformLayout();
            gpbCompromissos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCompromissos;
        private GroupBox gpbAdicionarOuEditarCompromisso;
        private DateTimePicker dtpDataHora;
        private TextBox txbTitulo;
        private Label lblTitulo;
        private Button btnAgendar;
        private Label lblDataHora;
        private TextBox txbDescricao;
        private Label lblDescricao;
        private Button btnEditar;
        private Button btnExcluir;
        private GroupBox gpbCompromissos;
        private Button btnLimpar;
    }
}
