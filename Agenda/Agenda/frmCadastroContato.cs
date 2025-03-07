using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            lblInserir.Enabled = false;
            lblLocalizar.Enabled = false;
            lblAlterar.Enabled = false;
            lblExcluir.Enabled = false;
            lblSalvar.Enabled = false;
            lblCancelar.Enabled = false;

            switch (op)
            {
                case 1:
                    txtCodigo.Enabled = false;
                    btInserir.Enabled = true;
                    btLocalizar.Enabled = true;
                    lblInserir.Enabled = true;
                    lblLocalizar.Enabled = true;
                    break;

                case 2:
                    pDados.Enabled = true;
                    btSalvar.Enabled = true;
                    btCancelar.Enabled = true;
                    lblSalvar.Enabled = true;
                    lblCancelar.Enabled = true;
                    break;

                case 3:
                    btExcluir.Enabled = true;
                    btAlterar.Enabled = true;
                    lblAlterar.Enabled = true;
                    lblExcluir.Enabled = true;
                    btCancelar.Enabled = true;
                    lblCancelar.Enabled = true;
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

            btInserir.Image = new Bitmap(Properties.Resources.Inserir100x100, new Size(90, 90));
            btLocalizar.Image = new Bitmap(Properties.Resources.Localizar100x100, new Size(90, 90));
            btAlterar.Image = new Bitmap(Properties.Resources.Alterar100x100, new Size(90, 90));
            btExcluir.Image = new Bitmap(Properties.Resources.Excluir100x100, new Size(90, 90));
            btSalvar.Image = new Bitmap(Properties.Resources.Salvar100x100, new Size(90, 90));
            btCancelar.Image = new Bitmap(Properties.Resources.Cancelar100x100, new Size(90, 90));

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
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("O campo NOME é obrigatório!");
                    return;
                }
                if (!Regex.IsMatch(txtNome.Text, "^[a-zA-ZÀ-ÿ ]+$"))
                {
                    MessageBox.Show("O campo NOME deve conter apenas letras!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEndereco.Text))
                {
                    MessageBox.Show("O campo ENDEREÇO é obrigatório!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtBairro.Text))
                {
                    MessageBox.Show("O campo BAIRRO é obrigatório!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCidade.Text))
                {
                    MessageBox.Show("O campo CIDADE é obrigatório!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEstado.Text) || txtEstado.Text.Length != 2)
                {
                    MessageBox.Show("O campo ESTADO deve conter 2 letras!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCep.Text) || !Regex.IsMatch(txtCep.Text, @"^\d{5}-\d{3}$"))
                {
                    MessageBox.Show("O campo CEP deve estar no formato 00000-000!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTelefone.Text) || !Regex.IsMatch(txtTelefone.Text, @"^\(\d{2}\) \d{5}-\d{4}$"))
                {
                    MessageBox.Show("O campo TELEFONE deve estar no formato (00) 00000-0000!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("O campo EMAIL deve estar em um formato válido!");
                    return;
                }


                Contato contato = new Contato();

                contato.Nome = txtNome.Text;
                contato.Rua = txtEndereco.Text;
                contato.Bairro = txtBairro.Text;
                contato.Cidade = txtCidade.Text;

                string cepFormatado = Regex.Replace(txtCep.Text, @"\D", "");
                contato.Cep = cepFormatado;
                
                contato.Estado = txtEstado.Text;

                string telefoneFormatado = Regex.Replace(txtTelefone.Text, @"\D", "");
                contato.Telefone = telefoneFormatado;

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
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            string numero = Regex.Replace(txtTelefone.Text, @"\D", ""); // Remove tudo que não for número

            if (numero.Length > 11) numero = numero.Substring(0, 11); // Limita a 11 caracteres

            if (numero.Length >= 2)
            {
                if (numero.Length <= 6)
                    txtTelefone.Text = $"({numero.Substring(0, 2)}) {numero.Substring(2)}";
                else if (numero.Length <= 10)
                    txtTelefone.Text = $"({numero.Substring(0, 2)}) {numero.Substring(2, 4)}-{numero.Substring(6)}";
                else
                    txtTelefone.Text = $"({numero.Substring(0, 2)}) {numero.Substring(2, 5)}-{numero.Substring(7)}"; // Formato correto para 11 dígitos
            }

            txtTelefone.SelectionStart = txtTelefone.Text.Length; // Mantém o cursor no final
        }


        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            string cep = Regex.Replace(txtCep.Text, @"\D", ""); // Remove caracteres não numéricos

            if (cep.Length > 5)
            {
                txtCep.Text = cep.Insert(5, "-"); // Insere o hífen no formato 00000-000
                txtCep.SelectionStart = txtCep.Text.Length; // Mantém o cursor no final
            }
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
