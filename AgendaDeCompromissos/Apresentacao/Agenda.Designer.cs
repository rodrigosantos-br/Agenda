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
            btnLimpar = new Button();
            btnAgendar = new Button();
            btnExcluir = new Button();
            gpbCompromissos = new GroupBox();
            tlpAgenda = new TableLayoutPanel();
            flpAgendarEditarLimpar = new FlowLayoutPanel();
            btnEditar = new Button();
            gpbAdicionarOuEditarCompromisso = new GroupBox();
            mtbDataHora = new MaskedTextBox();
            txbTitulo = new TextBox();
            lblTitulo = new Label();
            lblDataHora = new Label();
            txbDescricao = new TextBox();
            lblDescricao = new Label();
            flpExcluir = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvCompromissos).BeginInit();
            gpbCompromissos.SuspendLayout();
            tlpAgenda.SuspendLayout();
            flpAgendarEditarLimpar.SuspendLayout();
            gpbAdicionarOuEditarCompromisso.SuspendLayout();
            flpExcluir.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCompromissos
            // 
            dgvCompromissos.AllowUserToAddRows = false;
            dgvCompromissos.AllowUserToDeleteRows = false;
            dgvCompromissos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompromissos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCompromissos.BackgroundColor = Color.Lavender;
            dgvCompromissos.BorderStyle = BorderStyle.Fixed3D;
            dgvCompromissos.Dock = DockStyle.Fill;
            dgvCompromissos.Location = new Point(3, 19);
            dgvCompromissos.Margin = new Padding(10);
            dgvCompromissos.Name = "dgvCompromissos";
            dgvCompromissos.ReadOnly = true;
            dgvCompromissos.RowHeadersVisible = false;
            dgvCompromissos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompromissos.Size = new Size(736, 499);
            dgvCompromissos.TabIndex = 7;
            dgvCompromissos.TabStop = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(200, 10);
            btnLimpar.Margin = new Padding(10);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 39);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(10, 10);
            btnAgendar.Margin = new Padding(10);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(75, 39);
            btnAgendar.TabIndex = 3;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.None;
            btnExcluir.AutoSize = true;
            btnExcluir.Location = new Point(10, 10);
            btnExcluir.Margin = new Padding(10);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(64, 39);
            btnExcluir.TabIndex = 50;
            btnExcluir.TabStop = false;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // gpbCompromissos
            // 
            gpbCompromissos.AutoSize = true;
            gpbCompromissos.Controls.Add(dgvCompromissos);
            gpbCompromissos.Dock = DockStyle.Fill;
            gpbCompromissos.Location = new Point(323, 3);
            gpbCompromissos.Name = "gpbCompromissos";
            gpbCompromissos.Size = new Size(742, 521);
            gpbCompromissos.TabIndex = 13;
            gpbCompromissos.TabStop = false;
            gpbCompromissos.Text = "Compromissos";
            // 
            // tlpAgenda
            // 
            tlpAgenda.ColumnCount = 2;
            tlpAgenda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpAgenda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpAgenda.Controls.Add(flpAgendarEditarLimpar, 0, 1);
            tlpAgenda.Controls.Add(gpbCompromissos, 1, 0);
            tlpAgenda.Controls.Add(gpbAdicionarOuEditarCompromisso, 0, 0);
            tlpAgenda.Controls.Add(flpExcluir, 1, 1);
            tlpAgenda.Dock = DockStyle.Fill;
            tlpAgenda.Location = new Point(0, 0);
            tlpAgenda.Name = "tlpAgenda";
            tlpAgenda.RowCount = 2;
            tlpAgenda.RowStyles.Add(new RowStyle(SizeType.Percent, 88.8888855F));
            tlpAgenda.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpAgenda.Size = new Size(1068, 594);
            tlpAgenda.TabIndex = 14;
            // 
            // flpAgendarEditarLimpar
            // 
            flpAgendarEditarLimpar.Controls.Add(btnAgendar);
            flpAgendarEditarLimpar.Controls.Add(btnEditar);
            flpAgendarEditarLimpar.Controls.Add(btnLimpar);
            flpAgendarEditarLimpar.Dock = DockStyle.Fill;
            flpAgendarEditarLimpar.Location = new Point(3, 530);
            flpAgendarEditarLimpar.Name = "flpAgendarEditarLimpar";
            flpAgendarEditarLimpar.Size = new Size(314, 61);
            flpAgendarEditarLimpar.TabIndex = 5;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(105, 10);
            btnEditar.Margin = new Padding(10);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 39);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // gpbAdicionarOuEditarCompromisso
            // 
            gpbAdicionarOuEditarCompromisso.AutoSize = true;
            gpbAdicionarOuEditarCompromisso.Controls.Add(mtbDataHora);
            gpbAdicionarOuEditarCompromisso.Controls.Add(txbTitulo);
            gpbAdicionarOuEditarCompromisso.Controls.Add(lblTitulo);
            gpbAdicionarOuEditarCompromisso.Controls.Add(lblDataHora);
            gpbAdicionarOuEditarCompromisso.Controls.Add(txbDescricao);
            gpbAdicionarOuEditarCompromisso.Controls.Add(lblDescricao);
            gpbAdicionarOuEditarCompromisso.Dock = DockStyle.Fill;
            gpbAdicionarOuEditarCompromisso.Location = new Point(3, 3);
            gpbAdicionarOuEditarCompromisso.Name = "gpbAdicionarOuEditarCompromisso";
            gpbAdicionarOuEditarCompromisso.Size = new Size(314, 521);
            gpbAdicionarOuEditarCompromisso.TabIndex = 10;
            gpbAdicionarOuEditarCompromisso.TabStop = false;
            gpbAdicionarOuEditarCompromisso.Text = "Adicionar ou Editar Compromisso";
            // 
            // mtbDataHora
            // 
            mtbDataHora.BackColor = Color.Lavender;
            mtbDataHora.Location = new Point(34, 97);
            mtbDataHora.Mask = "00/00/0000 90:00";
            mtbDataHora.Name = "mtbDataHora";
            mtbDataHora.Size = new Size(160, 23);
            mtbDataHora.TabIndex = 1;
            mtbDataHora.ValidatingType = typeof(DateTime);
            // 
            // txbTitulo
            // 
            txbTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbTitulo.BackColor = Color.Lavender;
            txbTitulo.Location = new Point(34, 37);
            txbTitulo.Margin = new Padding(10);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(160, 23);
            txbTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(34, 19);
            lblTitulo.Margin = new Padding(50);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            // 
            // lblDataHora
            // 
            lblDataHora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDataHora.AutoSize = true;
            lblDataHora.Location = new Point(34, 79);
            lblDataHora.Margin = new Padding(10);
            lblDataHora.Name = "lblDataHora";
            lblDataHora.Size = new Size(69, 15);
            lblDataHora.TabIndex = 1;
            lblDataHora.Text = "Data e Hora";
            // 
            // txbDescricao
            // 
            txbDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbDescricao.BackColor = Color.Lavender;
            txbDescricao.Location = new Point(34, 157);
            txbDescricao.Margin = new Padding(10);
            txbDescricao.Multiline = true;
            txbDescricao.Name = "txbDescricao";
            txbDescricao.Size = new Size(238, 313);
            txbDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            lblDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(34, 139);
            lblDescricao.Margin = new Padding(10);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição";
            // 
            // flpExcluir
            // 
            flpExcluir.Controls.Add(btnExcluir);
            flpExcluir.Dock = DockStyle.Fill;
            flpExcluir.Location = new Point(323, 530);
            flpExcluir.Name = "flpExcluir";
            flpExcluir.Size = new Size(742, 61);
            flpExcluir.TabIndex = 15;
            // 
            // fmrAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 594);
            Controls.Add(tlpAgenda);
            Name = "fmrAgenda";
            Text = "Agenda";
            Load += Agenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompromissos).EndInit();
            gpbCompromissos.ResumeLayout(false);
            tlpAgenda.ResumeLayout(false);
            tlpAgenda.PerformLayout();
            flpAgendarEditarLimpar.ResumeLayout(false);
            gpbAdicionarOuEditarCompromisso.ResumeLayout(false);
            gpbAdicionarOuEditarCompromisso.PerformLayout();
            flpExcluir.ResumeLayout(false);
            flpExcluir.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCompromissos;
        private Button btnAgendar;
        private Button btnExcluir;
        private GroupBox gpbCompromissos;
        private Button btnLimpar;
        private TableLayoutPanel tlpAgenda;
        private FlowLayoutPanel flpAgendarEditarLimpar;
        private Button btnEditar;
        private FlowLayoutPanel flpExcluir;
        private GroupBox gpbAdicionarOuEditarCompromisso;
        private TextBox txbTitulo;
        private Label lblTitulo;
        private Label lblDataHora;
        private TextBox txbDescricao;
        private Label lblDescricao;
        private MaskedTextBox mtbDataHora;
    }
}
