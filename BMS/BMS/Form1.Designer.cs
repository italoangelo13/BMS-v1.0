namespace BMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this._barraStatusLogin = new System.Windows.Forms.StatusStrip();
            this._lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this._btnAcessar = new System.Windows.Forms.Button();
            this._edSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._edUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this._barraStatusLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BMS.Properties.Resources.background_triangulos_livrit;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this._barraStatusLogin);
            this.panel1.Controls.Add(this._btnAcessar);
            this.panel1.Controls.Add(this._edSenha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this._edUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 456);
            this.panel1.TabIndex = 0;
            // 
            // _barraStatusLogin
            // 
            this._barraStatusLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblData,
            this.toolStripStatusLabel1,
            this.lblEmpresa});
            this._barraStatusLogin.Location = new System.Drawing.Point(0, 434);
            this._barraStatusLogin.Name = "_barraStatusLogin";
            this._barraStatusLogin.Size = new System.Drawing.Size(430, 22);
            this._barraStatusLogin.TabIndex = 4;
            // 
            // _lblData
            // 
            this._lblData.Name = "_lblData";
            this._lblData.Size = new System.Drawing.Size(22, 17);
            this._lblData.Text = "---";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel1.Text = "||";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(22, 17);
            this.lblEmpresa.Text = "---";
            // 
            // _btnAcessar
            // 
            this._btnAcessar.BackColor = System.Drawing.Color.DarkRed;
            this._btnAcessar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this._btnAcessar.FlatAppearance.BorderSize = 2;
            this._btnAcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this._btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAcessar.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAcessar.ForeColor = System.Drawing.Color.White;
            this._btnAcessar.Location = new System.Drawing.Point(157, 377);
            this._btnAcessar.Name = "_btnAcessar";
            this._btnAcessar.Size = new System.Drawing.Size(114, 38);
            this._btnAcessar.TabIndex = 2;
            this._btnAcessar.Text = "ACESSAR";
            this._btnAcessar.UseVisualStyleBackColor = false;
            this._btnAcessar.Click += new System.EventHandler(this._btnAcessar_Click);
            // 
            // _edSenha
            // 
            this._edSenha.Font = new System.Drawing.Font("Roboto Slab", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._edSenha.ForeColor = System.Drawing.Color.LightCoral;
            this._edSenha.Location = new System.Drawing.Point(92, 329);
            this._edSenha.Name = "_edSenha";
            this._edSenha.PasswordChar = '*';
            this._edSenha.Size = new System.Drawing.Size(250, 29);
            this._edSenha.TabIndex = 1;
            this._edSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._edSenha.UseSystemPasswordChar = true;
            this._edSenha.WordWrap = false;
            this._edSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this._edSenha_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(169, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // _edUsuario
            // 
            this._edUsuario.Font = new System.Drawing.Font("Roboto Slab", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._edUsuario.ForeColor = System.Drawing.Color.LightCoral;
            this._edUsuario.Location = new System.Drawing.Point(92, 245);
            this._edUsuario.Name = "_edUsuario";
            this._edUsuario.Size = new System.Drawing.Size(250, 29);
            this._edUsuario.TabIndex = 0;
            this._edUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._edUsuario.WordWrap = false;
            this._edUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this._edUsuario_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(169, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::BMS.Properties.Resources.logo_bms;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 208);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 456);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACESSO AO SISTEMA - BMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this._barraStatusLogin.ResumeLayout(false);
            this._barraStatusLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox _edUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _edSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnAcessar;
        private System.Windows.Forms.StatusStrip _barraStatusLogin;
        private System.Windows.Forms.ToolStripStatusLabel _lblData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblEmpresa;

    }
}

