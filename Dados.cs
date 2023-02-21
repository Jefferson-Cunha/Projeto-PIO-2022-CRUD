using System;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Linq;
using System.Collections.Generic;



namespace projetoContasemDia_0._0._1
{
    class Dados
    {
        SqlConnection con;
        SqlCommand cmd;


        private void conectar()
        {
            con = new SqlConnection("Data Source=JEFFERSON_CUNHA\\SQLEXPRESS1;Initial Catalog = dbUsuario; Integrated Security = True");
        }


        //Cadastrar usuário no Banco de Dados
        public bool inserirUsuario(String Nome, String Email, String Celular, String Senha)
        {

            try
            {
                conectar();
                cmd = new SqlCommand("INSERT INTO tbClientes(Nome, Email, Celular, Senha) VALUES(@nome, @email, @celular, @senha)", con);

                con.Open();
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@celular", Celular);
                cmd.Parameters.AddWithValue("@senha", Senha);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        //Autenticar E-mail e Senha
        public bool realizarLogin(String Email, String Senha)
        {
            bool retorno = false;

            try
            {
                conectar();
                con.Open();
                string sql = "SELECT * FROM tbClientes WHERE Email = '" + Email + "'";
                SqlCommand Cmd = new SqlCommand(sql, con);
                SqlDataReader adoDR = Cmd.ExecuteReader();

                if (adoDR.HasRows)
                {
                    if (adoDR.Read())
                    {
                        bool v = Senha == adoDR["Senha"].ToString();
                        if (v)
                        {
                            retorno = true;
                            return retorno;
                        }
                    }
                    {
                        return retorno;
                    }
                }
            }

            catch (Exception) {throw;}

            return retorno;
        }

        

        //Consultar Nome e Celualar
        public bool consultarNomeCelular(String Nome, String Celular)
        {
            bool retorno = false;

            try {

                conectar();
                con.Open();
                string sql = "SELECT * FROM  tbClientes WHERE Nome = '" + Nome + "' ";
                SqlCommand Cmd = new SqlCommand(sql, con);
                SqlDataReader adoDR = Cmd.ExecuteReader();


                if (adoDR.HasRows)
                {
                    if (adoDR.Read())
                    {
                        bool v = Celular == adoDR["Celular"].ToString();
                        if (v)
                        {
                            retorno = true;
                            return retorno;
                        }
                    }
                    {
                        return retorno;
                    }
                }
            }
             catch(Exception) {throw;};
            {

                return retorno;

            }

            
        }


        //Alterar Senha
        public bool AlterarSenha(String Nome, String Senha)
        {

            bool retorno = false;
            
            try
            {
                conectar();
                cmd = new SqlCommand("UPDATE tbClientes SET Senha = '" + Senha + "' WHERE Nome = '" + Nome + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                
                retorno = true;
                return retorno;
            }
            catch (Exception) {throw;}

            
        
        }


        // Inserir Nova Conta

        public bool InserirConta(String TpConta, String VlConta, String cdProprio, String DtVencimento)
        {
            try
            {
                conectar();
                cmd = new SqlCommand("INSERT INTO tbContas(TpConta, VlConta, CodProprio, DtVencimento) VALUES(@TpConta, @VlConta, @CodProprio, @DtVencimento)", con);

                con.Open();
                cmd.Parameters.AddWithValue("@TpConta", TpConta);
                cmd.Parameters.AddWithValue("@VlConta", VlConta);
                cmd.Parameters.AddWithValue("@CodProprio", cdProprio);
                cmd.Parameters.AddWithValue("@DtVencimento", DtVencimento);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch 
            {
                throw;
            }
        }


        // listar as contas 
                  
        public bool listarContas(ref DataTable tbContas)
        {
            bool retorno = false;

            try
            {
                conectar();
                string sql = "SELECT * FROM tbContas";

                //abre a conexao
                con.Open();
                
                //cria o objeto command para executar a instruçao sql
                SqlCommand cmd = new SqlCommand(sql, con);



                //define o tipo do comando
                cmd.CommandType = CommandType.Text;
                
                //cria um dataadapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);


                //cria um objeto datatable
                tbContas = new DataTable();

                //preenche o datatable via dataadapter
                da.Fill(tbContas);



                retorno = true;
                return retorno;
            }
            catch { throw;}

            
        }



        // Excluir contas do usuário!
        public bool excluirContas(String cdProprio)
        {          
           bool retorno = false;

            try
            {
                conectar();
                cmd = new SqlCommand("DELETE FROM tbContas WHERE CodProprio = '" + cdProprio + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                retorno = true;
                return retorno;


            }
            catch {throw;}

            
        }


        // Editar conta do usuário

        public bool alterarConta(String TpConta, String VlConta, String cdProprio, String DtVencimento)
        {
            bool retorno = false;

            try
            {
                conectar();
                cmd = new SqlCommand("UPDATE tbContas SET TpConta = '" + TpConta + "', VlConta = '" + VlConta + "', DtVencimento = '" + DtVencimento +"' WHERE CodProprio = '" + cdProprio + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                retorno = true;
                return retorno;
            }
            catch (Exception) { throw; }

        }



    }
}




