using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.Administrativo
{
    public partial class Pesquisa_Funcionario : Form
    {
        public Pesquisa_Funcionario()
        {
            InitializeComponent();
        }

        private void Controle_Funcionario_Load(object sender, EventArgs e)
        {
            _ddlFiltros.SelectedIndex = 0;
            _edDataInicial.Text = DateTime.Now.AddDays(-30).ToString("dd/MM/yyyy");
            _edDataFinal.Text = DateTime.Now.ToString("dd/MM/yyyy");

            this.Text = "Controle de Funcionarios - " + Controle.NomeEmpresa;
            BancoDados banco = new BancoDados();
            banco.Query(@"SELECT FUNC_CODIGO_ID AS CODIGO,
                                FUNC_NOME_COMPLETO AS NOME,
                                car_nome AS CARGO,
                                CONCAT(FUNC_ENDERECO,', ',FUNC_NUMERO,', ', FUNC_BAIRRO, ', ',MUN_NOME,' - ',FUNC_UF) AS ENDERECO,
                                FUNC_CPF AS CPF,
                                FUNC_DATA_ADMISSAO AS DATA_ADMISSAO
                                FROM funcionario
                                LEFT join cargos on (car_codigo_id = FUNC_CODIGO_CARGO)
                                LEFT join municipio on (FUNC_CODIGO_CIDADE = mun_codigo_iBGE)");
            try
            {
                _gridFuncionario.DataSource = banco.ExecutarDataTable();
            }
            catch
            {
                MessageBox.Show("Não foi possivel carregar as informações.", "Erro de Carregamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void _gridFuncionario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("Não foi possivel carregar as informações.", "Erro de Carregamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
