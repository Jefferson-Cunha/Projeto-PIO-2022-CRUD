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
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            txtSenhaVazia.Text = "";
            txtEmailVazio.Text = "";
            txtPreencherCampos.Text = "";


            String email = txtEmailUsuario.Text;
            String senha = txtSenhaUsuario.Text;

            Boolean camposVazio = email == "" && senha == "";

            if (camposVazio)
            {
                txtSenhaVazia.Text = "";
                txtEmailVazio.Text = "";
                txtPreencherCampos.Text = "Informe os dados solicitados!";
                
            } 
              else
               { 
               Boolean senhaVazia = senha == "";
               Boolean emailVazio = email == "";

                if (senhaVazia)
                {
                    txtSenhaVazia.Text = "Informe a senha!";
                } 
                     else if (emailVazio)
                    {
                        txtEmailVazio.Text = "Informe o e-mail!";
                    }
                else
                {
                    telaAreaLogada telaAreaLogada = new telaAreaLogada();
                    telaAreaLogada.Show();
                    this.Hide();

                }
               }    
        }

        private void lnkFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaBemVindo teleBemVindo = new telaBemVindo();
            teleBemVindo.Show();
            this.Hide();
        }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            telaRecuperarSenha telaRecuperarSenha = new telaRecuperarSenha();
            telaRecuperarSenha.Show();
            this.Hide();
   
        }
    }
}
