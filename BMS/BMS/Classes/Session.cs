using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Classes
{
    static class Session
    {
        private static string nomeUsuario;
        private static string login;
        private static string cargo;
        private static string codUsuario;

        public static string NomeUsuario
        {
            get { return Session.nomeUsuario; }
            set { Session.nomeUsuario = value; }
        }
        

        public static string Login
        {
            get { return Session.login; }
            set { Session.login = value; }
        }
        

        public static string Cargo
        {
            get { return Session.cargo; }
            set { Session.cargo = value; }
        }
        

        public static string CodUsuario
        {
            get { return Session.codUsuario; }
            set { Session.codUsuario = value; }
        }


        
    }
}
