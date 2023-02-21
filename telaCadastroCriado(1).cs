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
    public partial class telaCadastroCriado : Form
    {
        public telaCadastroCriado()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            telaLogin telaLogin = new telaLogin();
            telaLogin.Show();
            this.Hide();
        }
    }
}
