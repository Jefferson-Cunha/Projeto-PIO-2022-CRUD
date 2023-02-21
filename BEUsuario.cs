using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projetoContasemDia_0._0._1
{
    internal class BEUsuario
    {



        //Cadastrar usuário no Banco de Dados
        private Dados objDados = new Dados();
        public bool inserir(String Nome, String Email, String Celular, String Senha)
        {
            return objDados.inserirUsuario(Nome, Email, Celular, Senha);
        }




        //Autenticar E-mail e Senha
        public bool login(String Email, String Senha)
        {
            try
            {
                return objDados.realizarLogin(Email, Senha);

            }
            catch { throw;}
        }

        //Consultar Nome e Celular
        public bool consultarNomeCelular(String Nome, String Celular)
        {

            try
            {
                return objDados.consultarNomeCelular(Nome, Celular);

            }
            catch {throw;}

        }


        //Alterar Senha
        public bool AlterarSenha(String Nome, String Senha)
        {
            try
            {
               return objDados.AlterarSenha(Nome, Senha);
            }
            catch { throw;};
        }




        // Inserir Nova Conta

        public bool InserirConta(String TpConta, String VlConta, String cdProprio, String DtVencimento)
        {
            try
            {
                
                return objDados.InserirConta(TpConta, VlConta, cdProprio, DtVencimento);
           
            } catch { throw; }
        }

        // Listas contas do usuário
        public bool consultaPorRef(ref DataTable tbContas)
        {
            try
            {
                return objDados.listarContas(ref tbContas);
            }
            catch { throw; }
        }



        //Excluir contas usuário

        public bool excluirContas(String cdProrio)
        {
            try
            {
                return objDados.excluirContas(cdProrio);
            }
            catch { throw; }
                

        }



        // Editar conta do usuário

        public bool alterarConta(String TpConta, String VlConta, String cdProprio, String DtVencimento)
        {
            try
            {
                return objDados.alterarConta(TpConta, VlConta, cdProprio, DtVencimento);
            }
            catch { throw; }
        }


    }
}
