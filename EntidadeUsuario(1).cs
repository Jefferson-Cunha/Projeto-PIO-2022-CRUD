using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoContasemDia_0._0._1
{
    class EntidadeUsuario
    {
        private String nome;
        private String email;
        private String celular;
        private String senha;

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
