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
using BMS.Classes;

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
            if (String.IsNullOrEmpty(_edUsuario.Text))
            {
                MessageBox.Show("Informe o seu login.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _edUsuario.Focus();
                return;
            }

            if (String.IsNullOrEmpty(_edSenha.Text))
            {
                MessageBox.Show("Informe a sua senha.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _edSenha.Focus();
                return;
            }

            if (_edUsuario.Text.ToUpper() == "ADMIN" && _edSenha.Text == "bms2018")
            {
                Session.CodUsuario = "0";
                Session.NomeUsuario = "Administrador";
                Session.Login = "ADMIN";
                Session.Cargo = "1";
                Dashboard tela = new Dashboard();
                tela.Show();
                this.Hide();
            }
            else
            {
                Usuario user = new Usuario();
                if (user.autenticarUsuario(_edUsuario.Text, _edSenha.Text) == true)
                {
                    BancoDados banco = new BancoDados();
                    banco.Query(@"SELECT USU_CODIGO_ID, 
                                USU_NOME, 
                                USU_LOGIN, 
                                car_codigo_id 
                                FROM usuario
                                    inner join funcionario on (USU_CODIGO_FUNC_ID = func_codigo_id)
                                    inner join cargos on (func_codigo_cargo = car_codigo_id)
                        WHERE USU_LOGIN = ?USU_LOGIN");
                    banco.SetParametro("?USU_LOGIN", _edUsuario.Text);
                    DataTable dt = banco.ExecutarDataTable();
                    if (dt.Rows.Count > 0)
                    {
                        Session.CodUsuario = dt.Rows[0]["USU_CODIGO_ID"].ToString().ToUpper();
                        Session.NomeUsuario = dt.Rows[0]["USU_NOME"].ToString().ToUpper();
                        Session.Login = dt.Rows[0]["USU_LOGIN"].ToString().ToUpper();
                        Session.Cargo = dt.Rows[0]["car_codigo_id"].ToString().ToUpper();
                        Dashboard tela = new Dashboard();
                        tela.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Acesso Negado, Login ou Senha incorretos", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                        
        }

        

        private void _edUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _edSenha.Focus();
            }
        }

        private void _edSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _btnAcessar_Click(null, null);
            }
        }
    }
}
