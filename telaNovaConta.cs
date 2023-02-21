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
    public partial class telaNovaConta : Form
    {
        BFFUsuario objBFF = new BFFUsuario();


        public telaNovaConta()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void telaNovaConta_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            txtPrestador.SuspendLayout();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String TpConta = txtTpConta.Text;
            String VlConta = txtVlConta.Text;
            String cdProprio = txtPrestador.Text;
            String DtVencimento = DtVenci.Text;




            // Verificando se todos os campos foram preenchidos!
            
            bool camposPreenchidos = TpConta == "" && VlConta == "" && cdProprio == "";
            bool conta = TpConta == "";
            bool valor = VlConta == "";
            bool codigo = cdProprio == "";

            if (camposPreenchidos)
            {
                txtCampoVazio.Text = "Preenchas os campos acima!";
            } 
            
            
            else if (conta)
            {
              txtCampoVazio.Text = "Preencha o campo conta!";
            }


            else if (valor)
            {
                txtCampoVazio.Text = "Preencha o campo valor!";
            }


            else if (codigo)
            {
                txtCampoVazio.Text = "Preencha o campo código!!";
            }

            else
            {

                try
                {
                    bool inserirConta = objBFF.InserirConta(TpConta, VlConta, cdProprio, DtVencimento); ;

                    if (inserirConta)
                    {
                        TelaContaInserida telaConta = new TelaContaInserida();
                        telaConta.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir conta! => " + ex.Message.ToString());
                }

            }





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtVlConta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

