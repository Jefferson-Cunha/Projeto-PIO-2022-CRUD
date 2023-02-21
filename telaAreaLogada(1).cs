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
    }
}
