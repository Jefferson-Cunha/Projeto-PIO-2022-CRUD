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
    public partial class telaAtualizarSenha : Form
    {
        public telaAtualizarSenha()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            telaSenhaAlterada telaSenhaAlterada = new telaSenhaAlterada();
            telaSenhaAlterada.Show();
            this.Hide();

        }
    }
}
