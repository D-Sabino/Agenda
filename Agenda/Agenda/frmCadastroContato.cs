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
                    txtCodigo.Enabled = false;
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
            carregaImagens();
            this.AlteraBotoes(1);
        }

        public void carregaImagens()
        {
            btInserir.Image = Properties.Resources.Inserir100x100;
            btLocalizar.Image = Properties.Resources.Localizar100x100;
            btAlterar.Image = Properties.Resources.Alterar100x100;
            btExcluir.Image = Properties.Resources.Excluir100x100;
            btSalvar.Image = Properties.Resources.Salvar100x100;
            btCancelar.Image = Properties.Resources.Cancelar100x100;

            btInserir.Image = new Bitmap(Properties.Resources.Inserir100x100, new Size(100, 100));
            btLocalizar.Image = new Bitmap(Properties.Resources.Localizar100x100, new Size(100, 100));
            btAlterar.Image = new Bitmap(Properties.Resources.Alterar100x100, new Size(100, 100));
            btExcluir.Image = new Bitmap(Properties.Resources.Excluir100x100, new Size(100, 100));
            btSalvar.Image = new Bitmap(Properties.Resources.Salvar100x100, new Size(100, 100));
            btCancelar.Image = new Bitmap(Properties.Resources.Cancelar100x100, new Size(100, 100));

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

            String strConexao = DadosConexao.StringDeConexao;
            Conexao conexao = new Conexao(strConexao);
            DALContato dal = new DALContato(conexao);

            if (this.operacao == "inserir")
            {
                dal.Incluir(contato);
                MessageBox.Show("O código gerado foi:" + contato.Codigo.ToString());

            }
            else
            {
                contato.Codigo = Convert.ToInt32(txtCodigo.Text);
                dal.Alterar(contato);
                MessageBox.Show("Registro alterado com sucesso.");
            }
            this.AlteraBotoes(1);
            this.LimpaCampos();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaContatos f = new frmConsultaContatos();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                Conexao cx = new Conexao(DadosConexao.StringDeConexao);
                DALContato dal = new DALContato(cx);
                Contato contato = dal.CarregaContato(f.codigo);

                txtCodigo.Text = contato.Codigo.ToString();
                txtNome.Text = contato.Nome;
                txtEndereco.Text = contato.Rua;
                txtEmail.Text = contato.Email;
                txtTelefone.Text = contato.Telefone;
                txtBairro.Text = contato.Bairro;
                txtCidade.Text = contato.Cidade;
                txtEstado.Text = contato.Estado;
                txtCep.Text = contato.Cep;

                this.AlteraBotoes(3);
            }
            else
            {
                this.LimpaCampos();
                this.AlteraBotoes(1);
            }
            f.Dispose();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                Conexao cx = new Conexao(DadosConexao.StringDeConexao);
                DALContato dal = new DALContato(cx);
                dal.Excluir(Convert.ToInt32(txtCodigo.Text));
                this.LimpaCampos();
                this.AlteraBotoes(1);
            }
        }
    }
}
