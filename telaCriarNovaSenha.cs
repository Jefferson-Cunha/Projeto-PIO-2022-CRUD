using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoContasemDia_0._0._1
{


    public partial class telaCriarNovaSenha : Form
    {


        private BFFUsuario objBFF = new BFFUsuario();
        private telaRecuperarSenha telaRecuperarSenha = new telaRecuperarSenha();
            

        public telaCriarNovaSenha()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public telaRecuperarSenha recuperarSenha = new telaRecuperarSenha();
      
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaBemVindo telaBemVindo = new telaBemVindo();
            telaBemVindo.Show();
            this.Hide();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            txtSenhaNaoConf.Text = "";

            String Senha = txtSenha.Text;
            String senha02 = txtSenha02.Text;
            String Nome = telaRecuperarSenha.nomeCliente();

            bool senhasPrenchidas = Senha != "" && senha02 != "";

            if (!senhasPrenchidas)
            {
                txtSenhaNaoConf.Text = "Verificar os campos acima!";

            } else
            {
                bool senhaConf = Senha == senha02;

                if (!senhaConf)
                {
                    txtSenhaNaoConf.Text = "Verificar senhas digitadas!";
                    
                }
                else
                {

                    try
                    {
                        bool v = objBFF.alterarSenha(Nome, Senha);

                        if (v)
                        {
                            telaSenhaAlterada telaSenha = new telaSenhaAlterada();
                            telaSenha.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao alterar Senha! => " + ex.Message.ToString());
                    }

                    }



            }
        }
    }
}
