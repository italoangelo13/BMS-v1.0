namespace BMS.Administrativo
{
    partial class Pesquisa_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa_Funcionario));
            this.panel1 = new System.Windows.Forms.Panel();
            this._btnFuncionario = new System.Windows.Forms.TabControl();
            this._pnlFuncionario = new System.Windows.Forms.TabPage();
            this._gridFuncionario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._edDataFinal = new System.Windows.Forms.MaskedTextBox();
            this._edDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._pnlDetalhes = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._ddlFiltros = new System.Windows.Forms.ComboBox();
            this._edPesquisa = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAdm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this._btnFuncionario.SuspendLayout();
            this._pnlFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridFuncionario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this._btnFuncionario);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 444);
            this.panel1.TabIndex = 0;
            // 
            // _btnFuncionario
            // 
            this._btnFuncionario.Controls.Add(this._pnlFuncionario);
            this._btnFuncionario.Controls.Add(this._pnlDetalhes);
            this._btnFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnFuncionario.Location = new System.Drawing.Point(0, 52);
            this._btnFuncionario.Name = "_btnFuncionario";
            this._btnFuncionario.SelectedIndex = 0;
            this._btnFuncionario.Size = new System.Drawing.Size(851, 392);
            this._btnFuncionario.TabIndex = 1;
            // 
            // _pnlFuncionario
            // 
            this._pnlFuncionario.BackColor = System.Drawing.Color.WhiteSmoke;
            this._pnlFuncionario.Controls.Add(this._gridFuncionario);
            this._pnlFuncionario.Controls.Add(this.groupBox1);
            this._pnlFuncionario.Location = new System.Drawing.Point(4, 22);
            this._pnlFuncionario.Name = "_pnlFuncionario";
            this._pnlFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this._pnlFuncionario.Size = new System.Drawing.Size(843, 366);
            this._pnlFuncionario.TabIndex = 1;
            this._pnlFuncionario.Text = "Buscar Funcionario";
            // 
            // _gridFuncionario
            // 
            this._gridFuncionario.AllowUserToAddRows = false;
            this._gridFuncionario.AllowUserToDeleteRows = false;
            this._gridFuncionario.AllowUserToResizeColumns = false;
            this._gridFuncionario.AllowUserToResizeRows = false;
            this._gridFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gridFuncionario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this._gridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.cpf,
            this.dataAdm,
            this.endereco,
            this.cargo});
            this._gridFuncionario.Location = new System.Drawing.Point(7, 113);
            this._gridFuncionario.MultiSelect = false;
            this._gridFuncionario.Name = "_gridFuncionario";
            this._gridFuncionario.ReadOnly = true;
            this._gridFuncionario.Size = new System.Drawing.Size(830, 245);
            this._gridFuncionario.TabIndex = 1;
            this._gridFuncionario.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._gridFuncionario_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this._edPesquisa);
            this.groupBox1.Controls.Add(this._ddlFiltros);
            this.groupBox1.Controls.Add(this._edDataFinal);
            this.groupBox1.Controls.Add(this._edDataInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa Avançada";
            // 
            // _edDataFinal
            // 
            this._edDataFinal.Font = new System.Drawing.Font("Roboto Slab", 9.75F);
            this._edDataFinal.Location = new System.Drawing.Point(218, 12);
            this._edDataFinal.Mask = "00/00/0000";
            this._edDataFinal.Name = "_edDataFinal";
            this._edDataFinal.Size = new System.Drawing.Size(86, 25);
            this._edDataFinal.TabIndex = 1;
            this._edDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // _edDataInicial
            // 
            this._edDataInicial.Font = new System.Drawing.Font("Roboto Slab", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._edDataInicial.Location = new System.Drawing.Point(110, 12);
            this._edDataInicial.Mask = "00/00/0000";
            this._edDataInicial.Name = "_edDataInicial";
            this._edDataInicial.Size = new System.Drawing.Size(84, 25);
            this._edDataInicial.TabIndex = 1;
            this._edDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "á";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data de Admissão:";
            // 
            // _pnlDetalhes
            // 
            this._pnlDetalhes.Location = new System.Drawing.Point(4, 22);
            this._pnlDetalhes.Name = "_pnlDetalhes";
            this._pnlDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this._pnlDetalhes.Size = new System.Drawing.Size(843, 366);
            this._pnlDetalhes.TabIndex = 0;
            this._pnlDetalhes.Text = "Detalhes";
            this._pnlDetalhes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 52);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisa de Funcionarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Buscar por:";
            // 
            // _ddlFiltros
            // 
            this._ddlFiltros.BackColor = System.Drawing.Color.Snow;
            this._ddlFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._ddlFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ddlFiltros.Font = new System.Drawing.Font("Roboto Slab", 9.75F);
            this._ddlFiltros.FormattingEnabled = true;
            this._ddlFiltros.ItemHeight = 18;
            this._ddlFiltros.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "CPF",
            "Cargo"});
            this._ddlFiltros.Location = new System.Drawing.Point(110, 47);
            this._ddlFiltros.MaxDropDownItems = 6;
            this._ddlFiltros.Name = "_ddlFiltros";
            this._ddlFiltros.Size = new System.Drawing.Size(194, 26);
            this._ddlFiltros.TabIndex = 2;
            // 
            // _edPesquisa
            // 
            this._edPesquisa.Font = new System.Drawing.Font("Roboto Slab", 9.75F);
            this._edPesquisa.Location = new System.Drawing.Point(311, 47);
            this._edPesquisa.Name = "_edPesquisa";
            this._edPesquisa.Size = new System.Drawing.Size(427, 25);
            this._edPesquisa.TabIndex = 3;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "CODIGO";
            this.codigo.HeaderText = "Cod.";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codigo.Width = 30;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "NOME";
            this.nome.HeaderText = "Funcionario";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cpf
            // 
            this.cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cpf.DataPropertyName = "CPF";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataAdm
            // 
            this.dataAdm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataAdm.DataPropertyName = "DATA_ADMISSAO";
            this.dataAdm.HeaderText = "Dt. Admissão";
            this.dataAdm.Name = "dataAdm";
            this.dataAdm.ReadOnly = true;
            this.dataAdm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // endereco
            // 
            this.endereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endereco.DataPropertyName = "ENDERECO";
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cargo
            // 
            this.cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cargo.DataPropertyName = "CARGO";
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Controle_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 444);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Controle_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Controle_Funcionario_Load);
            this.panel1.ResumeLayout(false);
            this._btnFuncionario.ResumeLayout(false);
            this._pnlFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridFuncionario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl _btnFuncionario;
        private System.Windows.Forms.TabPage _pnlDetalhes;
        private System.Windows.Forms.TabPage _pnlFuncionario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _gridFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox _edDataFinal;
        private System.Windows.Forms.MaskedTextBox _edDataInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _edPesquisa;
        private System.Windows.Forms.ComboBox _ddlFiltros;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAdm;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
    }
}