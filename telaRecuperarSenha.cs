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



        public string nomeCliente()
        {
            String nome = txtNomeUsuario.Text;
            return nome;
        } 
       
        public telaRecuperarSenha()
        {
            InitializeComponent();
        }

             

        private BFFUsuario objBFF = new BFFUsuario();
       
        
        
        private void btnAcessar_Click(object sender, EventArgs e)
        {


            txtCamposVazios.Text = "";
            txtEmailVazio.Text = "";
            txtCelularVazio.Text = "";

            // Entrada

            String Nome = txtNomeUsuario.Text;
            String celular = txtCelularUsuario.Text;

            Boolean camposPrenchidos = Nome == "" && celular == "";

            if (camposPrenchidos)
            {
                txtCamposVazios.Text = "Informe os dados solicitados!";
            }
              else
            {
                Boolean campoNome = Nome == "";
                Boolean campoCelular = celular == "";

                if (campoNome)
                {
                    txtEmailVazio.Text = "Informe o nome!";
                } 
                  else if (campoCelular)
                  {
                    txtCelularVazio.Text = "Informe o celular!";
                  }
                else
                {

                    try
                    {
                        bool v = objBFF.consultarNomeCelular(Nome, celular);

                        if (v)
                        {
    
                            telaCriarNovaSenha telaCriarNovaSenha = new telaCriarNovaSenha();
                            telaCriarNovaSenha.Show();
                            this.Hide();
                                                       
                           
                        } else
                        {
                            txtCamposVazios.Text = "Verificar dados informados!";
                        }
                    }
                    catch (Exception) 
                    {  
                        

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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
