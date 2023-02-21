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
    public partial class telaAtualizarContaUsuario : Form
    {
        BFFUsuario objBFF = new BFFUsuario();

        public telaAtualizarContaUsuario()
        {
            InitializeComponent();
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
                    bool v = objBFF.alterarConta(TpConta, VlConta, cdProprio, DtVencimento);
                    if (v)
                    {
                        TelaContaInserida inserida = new TelaContaInserida();
                        inserida.Show();
                        this.Hide();
                    }


                }catch (Exception ex)
                {
                    MessageBox.Show("Erro ao alterar conta!!" + ex.ToString());
                }

               

            }
            
        }
    }
}
