using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoContasemDia_0._0._1
{
    internal class BFFUsuario
    {
        private BEUsuario objBEUsuario = new BEUsuario();
        public EntidadeUsuario objEntidadeUsuario = new EntidadeUsuario();
        public bool inserir()
        {
            return objBEUsuario.inserir(objEntidadeUsuario.Nome, objEntidadeUsuario.Email, objEntidadeUsuario.Celular, objEntidadeUsuario.Senha);
        }
    }
}
