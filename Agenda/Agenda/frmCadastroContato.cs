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

        public void LimpaCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();

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
            this.LimpaCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Nome = txtNome.Text;
            contato.Rua = txtEndereco.Text;
            contato.Bairro = txtBairro.Text;
            contato.Cidade = txtCidade.Text;
            contato.Cep = txtCep.Text;
            contato.Estado = txtEstado.Text;
            contato.Telefone = txtTelefone.Text;
            contato.Email = txtEmail.Text;


            if (this.operacao == "inserir")
            {
                String strConexao = "Host=localhost;Port=5432;Database=Agenda;Username=postgres;Password=1234;";
                Conexao conexao = new Conexao(strConexao);

                try
                {
                    conexao.Conectar();
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
            else
            {
                contato.Codigo = Convert.ToInt32(txtCodigo.Text);
                
                //Alterar contato que está sendo exibido em tela.
            }
        }
    }
}
