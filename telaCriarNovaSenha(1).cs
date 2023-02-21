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
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            txtCampoVazio.Text = "";

            String senha1 = txtSenha.Text;
            String senha2 = txtSenhaConf.Text;
            String emailCliente = "";

            Boolean camposPrenchidos = senha1 != "" && senha2 != "";

            if (camposPrenchidos)
            {
                emailCliente = recuperarSenha.emailCliente();

            } else
            {
                txtCampoVazio.Text = "   Informe os dados solicitados!";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaBemVindo telaBemVindo = new telaBemVindo();
            telaBemVindo.Show();
            this.Hide();
        }
    }
}
