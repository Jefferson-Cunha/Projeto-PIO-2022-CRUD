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
    public partial class telaNovoUsuario : Form
    {
        public telaNovoUsuario()
        {
            InitializeComponent();
        }

        
        private BFFUsuario objBFFUsuario = new BFFUsuario(); 
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            txtSenhaNaoConfere.Text = "";
            txtCampoVazio.Text = "";
            txtErrCriarCadastro.Text = "";

            // Entrada

            String nome = txtNovoUsuario.Text;
            String email = txtEmailUsuario.Text;
            String celular = txtCelularUsuario.Text;
            String senha01 = txtSenhaUsuario.Text;
            String senha02 = txtSenhaConf.Text;


            Boolean camposPrenchidos = nome != "" && email != "" && celular != ""
                 && senha01 != ""
                 && senha02 != "";


            if (!camposPrenchidos)
            {
                txtCampoVazio.Text = "Informe os dados solicititados!";
            }
            else
            {
                Boolean senhaConfere = senha01 == senha02;

                if (!senhaConfere)
                {
                    txtSenhaNaoConfere.Text = "Verificar senhas digitadas!";
                }
                else if (senhaConfere)
                {

                    objBFFUsuario.objEntidadeUsuario.Nome = nome;
                    objBFFUsuario.objEntidadeUsuario.Email = email;
                    objBFFUsuario.objEntidadeUsuario.Celular = celular;
                    objBFFUsuario.objEntidadeUsuario.Senha = senha01;

                    bool v = objBFFUsuario.inserir();
                    if (v)
                    {
                        telaCadastroCriado cadastroCriado = new telaCadastroCriado();
                        cadastroCriado.Show();
                        this.Hide();
                    }
                        else
                    {
                        txtErrCriarCadastro.Text = "Erro ao criar cadastro!";
                    }
                    
                    
                    
                    
                    
                    


                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaBemVindo telaBemVindo = new telaBemVindo();
            telaBemVindo.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaBemVindo telaBemVindo = new telaBemVindo();
            telaBemVindo.Show();
            this.Hide();
        }
    }
}
