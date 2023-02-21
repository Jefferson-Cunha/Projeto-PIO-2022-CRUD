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
    public partial class telaAreaLogada : Form
    {
        BFFUsuario objBFF = new BFFUsuario();

        public telaAreaLogada()
        {
            InitializeComponent();
        }

        private void lnkFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            telaConfirmacao telaConfirmacao = new telaConfirmacao();
            telaConfirmacao.Show();
            
        }

        private void telaAreaLogada_Load(object sender, EventArgs e)
        {


            
            
        
        
        }

        private void atualizarEmailToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            telaAtulizarEmail telaAtulizarEmail = new telaAtulizarEmail();
            telaAtulizarEmail.Show();
        }

        private void atualizarSenhaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void atualizarCelularToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaConfirmacao telaConfirmacao = new telaConfirmacao();
            telaConfirmacao.Show();
        }

        private void atualizarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaAtulizarEmail telaAtulizarEmail = new telaAtulizarEmail();
            telaAtulizarEmail.Show();
        }

        private void atualizarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaAtualizarSenha telaAtualizarSenha = new telaAtualizarSenha();

            telaAtualizarSenha.Show();

        }

        private void atualizarCelularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaAtualizarCelular telaAtualizarCelular = new telaAtualizarCelular();
            telaAtualizarCelular.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            telaNovaConta telaNovaConta = new telaNovaConta();
            telaNovaConta.Show();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable tbContas = null;
             
            try
            {
                if (objBFF.consultaPorRef(ref tbContas))
                {
                    dtContas.DataSource = tbContas;
                }

            } catch(Exception ex)
            {
                MessageBox.Show("Erro ao atualizar!! " + ex.Message.ToString());
            }
        }

        private void dtContas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            telaExcluirConta telaExcluir = new telaExcluirConta();
            telaExcluir.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            telaAtualizarContaUsuario telaAtualizar = new telaAtualizarContaUsuario();
            telaAtualizar.Show();
        }
    }
}
