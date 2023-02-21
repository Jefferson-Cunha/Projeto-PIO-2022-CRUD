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
    public partial class telaAtulizarEmail : Form
    {
        public telaAtulizarEmail()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            telaEmailAlterado telaEmailAlterado = new telaEmailAlterado();
            telaEmailAlterado.Show();
            this.Hide();
        }
    }
}
