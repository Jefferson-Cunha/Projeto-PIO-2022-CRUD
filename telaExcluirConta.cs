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
    public partial class telaExcluirConta : Form
    {
        private BFFUsuario objBFF = new BFFUsuario();
        public telaExcluirConta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cdProprio = codConta.Text;

            try
            {
               bool v = objBFF.excluirContas(cdProprio);

                if (v)
                {
                    telaContaExcluida contaExcluida = new telaContaExcluida();
                    this.Hide();
                    contaExcluida.Show();
                }

            } catch(Exception ex)
            {
                MessageBox.Show("Erro ao excluir conta" + ex.ToString()); 
            }
        }
    }
}
