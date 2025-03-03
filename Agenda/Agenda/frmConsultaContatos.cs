using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmConsultaContatos : Form
    {
        public frmConsultaContatos()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao(DadosConexao.StringDeConexao);
            DALContato dal = new DALContato(cx);

            dgDados.DataSource = dal.Localizar(txtValor.Text);
        }
    }
}
