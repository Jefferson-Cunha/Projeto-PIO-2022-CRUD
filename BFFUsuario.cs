using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projetoContasemDia_0._0._1
{
    internal class BFFUsuario
    {
        private BEUsuario objBEU = new BEUsuario();
        public EntidadeUsuario objEntidadeUsuario = new EntidadeUsuario();


        //Cadastrar usuário no Banco de Dados
        public bool inserir()
        {
            return objBEU.inserir(objEntidadeUsuario.Nome, objEntidadeUsuario.Email, objEntidadeUsuario.Celular, objEntidadeUsuario.Senha);
        }

        //Autenticar E-mail e Senha
        public bool loginUsuario(String Email, String Senha)
        {
            try
            {
                return objBEU.login(Email, Senha);

            }
            catch
            {
                throw;
            }
        }

        //Consultar Nome e Celular

        public bool consultarNomeCelular(string Nome, string Celular)
        {
            try
            {
                return objBEU.consultarNomeCelular(Nome, Celular);
            }
            catch { throw; }
        }


        //Alterar Senha
        public bool alterarSenha(String Nome, String Senha)
        {
            try
            {
                return objBEU.AlterarSenha(Nome, Senha);

            }
            catch  
            { 
                throw; 
            }
        }



        // Inserir Nova Conta

        public bool InserirConta(String TpConta, String VlConta, String cdProprio, String DtVencimento)
        {
            try
            {

                return objBEU.InserirConta(TpConta, VlConta, cdProprio, DtVencimento);

            }
            catch { throw; }
        }


        // Listar contas

        public bool consultaPorRef(ref DataTable tbContas)
        {
            try
            {
                return objBEU.consultaPorRef(ref tbContas);
            }
            catch { throw; }
        }


        //Excluir contas usuário

        public bool excluirContas(String cdProrio)
        {
            try
            {
                return objBEU.excluirContas(cdProrio);
            }
            catch { throw; }


        }

        // Editar conta do usuário

        public bool alterarConta(String TpConta, String VlConta, String cdProprio, String DtVencimento)
        {
            try
            {
                return objBEU.alterarConta(TpConta, VlConta, cdProprio, DtVencimento);
            }
            catch {throw;}
        }




    }
}
