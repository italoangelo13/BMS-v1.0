using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
    static class Controle
    {
        private static string nomeEmpresa;
        private static string logoEmpresa;
        
        
        public static string NomeEmpresa
        {
            get { return Controle.nomeEmpresa; }
            set { Controle.nomeEmpresa = value; }
        }
        

        public static string LogoEmpresa
        {
            get { return Controle.logoEmpresa; }
            set { Controle.logoEmpresa = value; }
        }
    }
}
