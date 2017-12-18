using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Classes
{
    class Usuario
    {
        private string login;
        private string senha;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }


        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }



        public bool autenticarUsuario(string login, string senha)
        {
            bool autenticado = false;
            BancoDados banco = new BancoDados();
            banco.Query(@"SELECT USU_LOGIN, USU_SENHA FROM USUARIO WHERE USU_LOGIN = ?USU_LOGIN");
            banco.SetParametro("?USU_LOGIN", login);
            DataTable dt = banco.ExecutarDataTable();
            if (dt.Rows.Count > 0)
            {
                if (senha.Equals(dt.Rows[0]["USU_SENHA"].ToString()))
                {
                    autenticado = true;
                }
                else
                {
                    autenticado = false;
                }
            }
            else
            {
                autenticado = false;
            }


            return autenticado;
        }

    }
}
