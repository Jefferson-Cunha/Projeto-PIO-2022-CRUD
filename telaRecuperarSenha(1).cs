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
    public partial class telaRecuperarSenha : Form
    {
        public telaRecuperarSenha()
        {
            InitializeComponent();
        }

             

        private void btnAcessar_Click(object sender, EventArgs e)
        {


            txtCamposVazios.Text = "";
            txtEmailVazio.Text = "";
            txtCelularVazio.Text = "";

            // Entrada

            String email = txtEmailUsuario.Text;
            String celular = txtCelularUsuario.Text;

            Boolean camposPrenchidos = email == "" && celular == "";

            if (camposPrenchidos)
            {
                txtCamposVazios.Text = "Informe os dados solicitados!";
            }
              else
            {
                Boolean campoEmail = email == "";
                Boolean campoCelular = celular == "";

                if (campoEmail)
                {
                    txtEmailVazio.Text = "Informe o E-mail!";
                } 
                  else if (campoCelular)
                  {
                    txtCelularVazio.Text = "Informe o celular!";
                  }
                else
                {
                    telaCriarNovaSenha telaCriarNovaSenha = new telaCriarNovaSenha();
                    telaCriarNovaSenha.Show();
                    this.Hide();
                }
            } 
        }

        public string emailCliente() => txtEmailUsuario.Text;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaBemVindo telaBemVindo = new telaBemVindo();
            telaBemVindo.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
