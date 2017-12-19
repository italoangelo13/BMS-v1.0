using BMS.Administrativo;
using BMS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.Text = "Dashboard - " + Controle.NomeEmpresa;
        }

        private void _btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do Sistema?", "Sair do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            Application.Exit();


        }

        private void pesquisarFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Session.Cargo == "1" || Session.Cargo == "2")
            {
                Pesquisa_Funcionario contFuncionarios = new Pesquisa_Funcionario();
                contFuncionarios.MdiParent = this;
                contFuncionarios.Show();
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar esta funcionalidade.", "Permissão Negada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        


    }
}
