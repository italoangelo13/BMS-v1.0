using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Fonts;

namespace BMS
{
    public partial class Form1 : Form
    {
        BancoDados banco = new BancoDados();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            banco.Query("SELECT EMP_NOME_REDUZIDO, EMP_LOGO FROM empresa");
            DataTable dt = banco.ExecutarDataTable();
            if (dt.Rows.Count > 0)
            {
                Controle.NomeEmpresa = dt.Rows[0]["EMP_NOME_REDUZIDO"].ToString().ToUpper();
                Controle.LogoEmpresa = dt.Rows[0]["EMP_LOGO"].ToString().ToUpper();

                _lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblEmpresa.Text = Controle.NomeEmpresa;

            }
            else
            {
                _lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblEmpresa.Text = "BMS - Business Management System";
            }
        }

        private void _btnAcessar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acesso Negado", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
