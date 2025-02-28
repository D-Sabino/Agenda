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
    public partial class frmCadastroContato : Form
    {
        public string operacao = "";

        public void AlteraBotoes(int op)
        {
            pDados.Enabled = false;
            btInserir.Enabled = false;
            btLocalizar.Enabled = false;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;

            switch (op)
            {
                case 1:
                    btInserir.Enabled = true;
                    btLocalizar.Enabled = true;
                    break;

                case 2:
                    pDados.Enabled = true;
                    btSalvar.Enabled = true;
                    btCancelar.Enabled = true;
                    break;

                case 3:
                    btExcluir.Enabled = true;
                    btAlterar.Enabled = true;
                    break;

            }

        }

        public frmCadastroContato()
        {
            InitializeComponent();
        }

        private void frmCadastroContato_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            //Implementar limpeza dos campos.
        }
    }
}
