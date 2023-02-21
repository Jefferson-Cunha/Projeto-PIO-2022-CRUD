using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoContasemDia_0._0._1
{
    internal class BEUsuario
    {
        private Dados objDados = new Dados();
        public bool inserir(String Nome, String Email, String Celular, String Senha)
        {
            return objDados.inserirUsuario(Nome, Email, Celular, Senha);
        }
    }
}
