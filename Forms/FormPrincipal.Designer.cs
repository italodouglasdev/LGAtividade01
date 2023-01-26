
namespace LGAtividade01.Forms
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonNovoCliente = new System.Windows.Forms.Button();
            this.buttonGravarCliente = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelCodigoCliente = new System.Windows.Forms.Label();
            this.textBoxCodigoCliente = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.labelQuantidadeClientes = new System.Windows.Forms.Label();
            this.textBoxCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.textBoxTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.ColumnCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPFCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefoneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditarCliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.dataGridViewContatos = new System.Windows.Forms.DataGridView();
            this.groupBoxContatos = new System.Windows.Forms.GroupBox();
            this.buttonNovoContato = new System.Windows.Forms.Button();
            this.buttonGravarContato = new System.Windows.Forms.Button();
            this.labelQuantidadeContatos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTelefoneContato = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNomeContato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigoContato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipoRelacionamentoContato = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnCodigoContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefoneContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoRelacionamentoContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditarContato = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.groupBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatos)).BeginInit();
            this.groupBoxContatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNovoCliente
            // 
            this.buttonNovoCliente.Location = new System.Drawing.Point(385, 273);
            this.buttonNovoCliente.Name = "buttonNovoCliente";
            this.buttonNovoCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoCliente.TabIndex = 21;
            this.buttonNovoCliente.Text = "Novo";
            this.buttonNovoCliente.UseVisualStyleBackColor = true;
            this.buttonNovoCliente.Click += new System.EventHandler(this.buttonNovoCliente_Click);
            // 
            // buttonGravarCliente
            // 
            this.buttonGravarCliente.Location = new System.Drawing.Point(467, 273);
            this.buttonGravarCliente.Name = "buttonGravarCliente";
            this.buttonGravarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonGravarCliente.TabIndex = 20;
            this.buttonGravarCliente.Text = "Gravar";
            this.buttonGravarCliente.UseVisualStyleBackColor = true;
            this.buttonGravarCliente.Click += new System.EventHandler(this.buttonGravarCliente_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigoCliente,
            this.ColumnCPFCliente,
            this.ColumnNomeCliente,
            this.ColumnTelefoneCliente,
            this.ColumnEditarCliente});
            this.dataGridViewClientes.Location = new System.Drawing.Point(18, 68);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.RowHeadersVisible = false;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(524, 199);
            this.dataGridViewClientes.TabIndex = 19;
            this.dataGridViewClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellClick);
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(456, 26);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelTelefone.TabIndex = 18;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelCodigoCliente
            // 
            this.labelCodigoCliente.AutoSize = true;
            this.labelCodigoCliente.Location = new System.Drawing.Point(18, 26);
            this.labelCodigoCliente.Name = "labelCodigoCliente";
            this.labelCodigoCliente.Size = new System.Drawing.Size(40, 13);
            this.labelCodigoCliente.TabIndex = 16;
            this.labelCodigoCliente.Text = "Código";
            // 
            // textBoxCodigoCliente
            // 
            this.textBoxCodigoCliente.Location = new System.Drawing.Point(18, 42);
            this.textBoxCodigoCliente.Name = "textBoxCodigoCliente";
            this.textBoxCodigoCliente.ReadOnly = true;
            this.textBoxCodigoCliente.Size = new System.Drawing.Size(64, 20);
            this.textBoxCodigoCliente.TabIndex = 15;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(360, 26);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(27, 13);
            this.labelCpf.TabIndex = 14;
            this.labelCpf.Text = "CPF";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Location = new System.Drawing.Point(85, 26);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(35, 13);
            this.labelNomeCliente.TabIndex = 12;
            this.labelNomeCliente.Text = "Nome";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(88, 42);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(269, 20);
            this.textBoxNomeCliente.TabIndex = 100;
            // 
            // labelQuantidadeClientes
            // 
            this.labelQuantidadeClientes.AutoSize = true;
            this.labelQuantidadeClientes.Location = new System.Drawing.Point(18, 270);
            this.labelQuantidadeClientes.Name = "labelQuantidadeClientes";
            this.labelQuantidadeClientes.Size = new System.Drawing.Size(114, 13);
            this.labelQuantidadeClientes.TabIndex = 22;
            this.labelQuantidadeClientes.Text = "Quantidade Clientes: 0";
            // 
            // textBoxCPFCliente
            // 
            this.textBoxCPFCliente.Location = new System.Drawing.Point(363, 42);
            this.textBoxCPFCliente.Mask = "999,999,999-99";
            this.textBoxCPFCliente.Name = "textBoxCPFCliente";
            this.textBoxCPFCliente.Size = new System.Drawing.Size(87, 20);
            this.textBoxCPFCliente.TabIndex = 101;
            // 
            // textBoxTelefoneCliente
            // 
            this.textBoxTelefoneCliente.Location = new System.Drawing.Point(459, 42);
            this.textBoxTelefoneCliente.Mask = "(99) 9999-9999";
            this.textBoxTelefoneCliente.Name = "textBoxTelefoneCliente";
            this.textBoxTelefoneCliente.Size = new System.Drawing.Size(83, 20);
            this.textBoxTelefoneCliente.TabIndex = 102;
            // 
            // ColumnCodigoCliente
            // 
            this.ColumnCodigoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCodigoCliente.HeaderText = "Cód.";
            this.ColumnCodigoCliente.Name = "ColumnCodigoCliente";
            this.ColumnCodigoCliente.ReadOnly = true;
            this.ColumnCodigoCliente.Width = 54;
            // 
            // ColumnCPFCliente
            // 
            this.ColumnCPFCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCPFCliente.HeaderText = "CPF";
            this.ColumnCPFCliente.Name = "ColumnCPFCliente";
            this.ColumnCPFCliente.ReadOnly = true;
            this.ColumnCPFCliente.Width = 52;
            // 
            // ColumnNomeCliente
            // 
            this.ColumnNomeCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomeCliente.HeaderText = "Nome";
            this.ColumnNomeCliente.Name = "ColumnNomeCliente";
            this.ColumnNomeCliente.ReadOnly = true;
            // 
            // ColumnTelefoneCliente
            // 
            this.ColumnTelefoneCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnTelefoneCliente.HeaderText = "Telefone";
            this.ColumnTelefoneCliente.Name = "ColumnTelefoneCliente";
            this.ColumnTelefoneCliente.ReadOnly = true;
            this.ColumnTelefoneCliente.Width = 74;
            // 
            // ColumnEditarCliente
            // 
            this.ColumnEditarCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ColumnEditarCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnEditarCliente.HeaderText = "Editar";
            this.ColumnEditarCliente.Name = "ColumnEditarCliente";
            this.ColumnEditarCliente.ReadOnly = true;
            this.ColumnEditarCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEditarCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnEditarCliente.Width = 59;
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.labelCodigoCliente);
            this.groupBoxCliente.Controls.Add(this.textBoxTelefoneCliente);
            this.groupBoxCliente.Controls.Add(this.textBoxNomeCliente);
            this.groupBoxCliente.Controls.Add(this.textBoxCPFCliente);
            this.groupBoxCliente.Controls.Add(this.labelNomeCliente);
            this.groupBoxCliente.Controls.Add(this.labelQuantidadeClientes);
            this.groupBoxCliente.Controls.Add(this.labelCpf);
            this.groupBoxCliente.Controls.Add(this.buttonNovoCliente);
            this.groupBoxCliente.Controls.Add(this.textBoxCodigoCliente);
            this.groupBoxCliente.Controls.Add(this.buttonGravarCliente);
            this.groupBoxCliente.Controls.Add(this.labelTelefone);
            this.groupBoxCliente.Controls.Add(this.dataGridViewClientes);
            this.groupBoxCliente.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(564, 308);
            this.groupBoxCliente.TabIndex = 103;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // dataGridViewContatos
            // 
            this.dataGridViewContatos.AllowUserToAddRows = false;
            this.dataGridViewContatos.AllowUserToDeleteRows = false;
            this.dataGridViewContatos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigoContato,
            this.ColumnNomeContato,
            this.ColumnTelefoneContato,
            this.ColumnTipoRelacionamentoContato,
            this.ColumnEditarContato});
            this.dataGridViewContatos.Location = new System.Drawing.Point(18, 65);
            this.dataGridViewContatos.Name = "dataGridViewContatos";
            this.dataGridViewContatos.ReadOnly = true;
            this.dataGridViewContatos.RowHeadersVisible = false;
            this.dataGridViewContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContatos.Size = new System.Drawing.Size(524, 114);
            this.dataGridViewContatos.TabIndex = 103;
            this.dataGridViewContatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContatos_CellClick);
            // 
            // groupBoxContatos
            // 
            this.groupBoxContatos.Controls.Add(this.label3);
            this.groupBoxContatos.Controls.Add(this.comboBoxTipoRelacionamentoContato);
            this.groupBoxContatos.Controls.Add(this.label1);
            this.groupBoxContatos.Controls.Add(this.labelQuantidadeContatos);
            this.groupBoxContatos.Controls.Add(this.textBoxTelefoneContato);
            this.groupBoxContatos.Controls.Add(this.buttonNovoContato);
            this.groupBoxContatos.Controls.Add(this.textBoxNomeContato);
            this.groupBoxContatos.Controls.Add(this.buttonGravarContato);
            this.groupBoxContatos.Controls.Add(this.dataGridViewContatos);
            this.groupBoxContatos.Controls.Add(this.label2);
            this.groupBoxContatos.Controls.Add(this.textBoxCodigoContato);
            this.groupBoxContatos.Controls.Add(this.label4);
            this.groupBoxContatos.Location = new System.Drawing.Point(12, 326);
            this.groupBoxContatos.Name = "groupBoxContatos";
            this.groupBoxContatos.Size = new System.Drawing.Size(564, 220);
            this.groupBoxContatos.TabIndex = 104;
            this.groupBoxContatos.TabStop = false;
            this.groupBoxContatos.Text = "Contatos";
            // 
            // buttonNovoContato
            // 
            this.buttonNovoContato.Location = new System.Drawing.Point(385, 182);
            this.buttonNovoContato.Name = "buttonNovoContato";
            this.buttonNovoContato.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoContato.TabIndex = 105;
            this.buttonNovoContato.Text = "Novo";
            this.buttonNovoContato.UseVisualStyleBackColor = true;
            this.buttonNovoContato.Click += new System.EventHandler(this.buttonNovoContato_Click);
            // 
            // buttonGravarContato
            // 
            this.buttonGravarContato.Location = new System.Drawing.Point(467, 182);
            this.buttonGravarContato.Name = "buttonGravarContato";
            this.buttonGravarContato.Size = new System.Drawing.Size(75, 23);
            this.buttonGravarContato.TabIndex = 104;
            this.buttonGravarContato.Text = "Gravar";
            this.buttonGravarContato.UseVisualStyleBackColor = true;
            this.buttonGravarContato.Click += new System.EventHandler(this.buttonGravarContato_Click);
            // 
            // labelQuantidadeContatos
            // 
            this.labelQuantidadeContatos.AutoSize = true;
            this.labelQuantidadeContatos.Location = new System.Drawing.Point(18, 182);
            this.labelQuantidadeContatos.Name = "labelQuantidadeContatos";
            this.labelQuantidadeContatos.Size = new System.Drawing.Size(119, 13);
            this.labelQuantidadeContatos.TabIndex = 103;
            this.labelQuantidadeContatos.Text = "Quantidade Contatos: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Código";
            // 
            // textBoxTelefoneContato
            // 
            this.textBoxTelefoneContato.Location = new System.Drawing.Point(363, 39);
            this.textBoxTelefoneContato.Mask = "(99) 9999-9999";
            this.textBoxTelefoneContato.Name = "textBoxTelefoneContato";
            this.textBoxTelefoneContato.Size = new System.Drawing.Size(83, 20);
            this.textBoxTelefoneContato.TabIndex = 110;
            // 
            // textBoxNomeContato
            // 
            this.textBoxNomeContato.Location = new System.Drawing.Point(88, 39);
            this.textBoxNomeContato.Name = "textBoxNomeContato";
            this.textBoxNomeContato.Size = new System.Drawing.Size(269, 20);
            this.textBoxNomeContato.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Nome";
            // 
            // textBoxCodigoContato
            // 
            this.textBoxCodigoContato.Location = new System.Drawing.Point(18, 39);
            this.textBoxCodigoContato.Name = "textBoxCodigoContato";
            this.textBoxCodigoContato.ReadOnly = true;
            this.textBoxCodigoContato.Size = new System.Drawing.Size(64, 20);
            this.textBoxCodigoContato.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Telefone";
            // 
            // comboBoxTipoRelacionamentoContato
            // 
            this.comboBoxTipoRelacionamentoContato.FormattingEnabled = true;
            this.comboBoxTipoRelacionamentoContato.Location = new System.Drawing.Point(452, 38);
            this.comboBoxTipoRelacionamentoContato.Name = "comboBoxTipoRelacionamentoContato";
            this.comboBoxTipoRelacionamentoContato.Size = new System.Drawing.Size(90, 21);
            this.comboBoxTipoRelacionamentoContato.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Relacionamento";
            // 
            // ColumnCodigoContato
            // 
            this.ColumnCodigoContato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCodigoContato.HeaderText = "Cód";
            this.ColumnCodigoContato.Name = "ColumnCodigoContato";
            this.ColumnCodigoContato.ReadOnly = true;
            this.ColumnCodigoContato.Width = 51;
            // 
            // ColumnNomeContato
            // 
            this.ColumnNomeContato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomeContato.HeaderText = "Nome";
            this.ColumnNomeContato.Name = "ColumnNomeContato";
            this.ColumnNomeContato.ReadOnly = true;
            // 
            // ColumnTelefoneContato
            // 
            this.ColumnTelefoneContato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnTelefoneContato.HeaderText = "Telefone";
            this.ColumnTelefoneContato.Name = "ColumnTelefoneContato";
            this.ColumnTelefoneContato.ReadOnly = true;
            this.ColumnTelefoneContato.Width = 74;
            // 
            // ColumnTipoRelacionamentoContato
            // 
            this.ColumnTipoRelacionamentoContato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnTipoRelacionamentoContato.HeaderText = "Relacionamento";
            this.ColumnTipoRelacionamentoContato.Name = "ColumnTipoRelacionamentoContato";
            this.ColumnTipoRelacionamentoContato.ReadOnly = true;
            this.ColumnTipoRelacionamentoContato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTipoRelacionamentoContato.Width = 109;
            // 
            // ColumnEditarContato
            // 
            this.ColumnEditarContato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEditarContato.HeaderText = "Editar";
            this.ColumnEditarContato.Name = "ColumnEditarContato";
            this.ColumnEditarContato.ReadOnly = true;
            this.ColumnEditarContato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEditarContato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnEditarContato.Width = 59;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 558);
            this.Controls.Add(this.groupBoxContatos);
            this.Controls.Add(this.groupBoxCliente);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatos)).EndInit();
            this.groupBoxContatos.ResumeLayout(false);
            this.groupBoxContatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNovoCliente;
        private System.Windows.Forms.Button buttonGravarCliente;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelCodigoCliente;
        private System.Windows.Forms.TextBox textBoxCodigoCliente;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Label labelQuantidadeClientes;
        private System.Windows.Forms.MaskedTextBox textBoxCPFCliente;
        private System.Windows.Forms.MaskedTextBox textBoxTelefoneCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCPFCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefoneCliente;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEditarCliente;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.DataGridView dataGridViewContatos;
        private System.Windows.Forms.GroupBox groupBoxContatos;
        private System.Windows.Forms.Label labelQuantidadeContatos;
        private System.Windows.Forms.Button buttonNovoContato;
        private System.Windows.Forms.Button buttonGravarContato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTipoRelacionamentoContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBoxTelefoneContato;
        private System.Windows.Forms.TextBox textBoxNomeContato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigoContato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefoneContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoRelacionamentoContato;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEditarContato;
    }
}