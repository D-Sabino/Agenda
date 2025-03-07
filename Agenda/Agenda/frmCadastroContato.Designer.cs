namespace Agenda
{
    partial class frmCadastroContato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pDados = new Panel();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtCep = new TextBox();
            lblCep = new Label();
            txtEstado = new TextBox();
            lblEstado = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            pMenu = new Panel();
            lblCancelar = new Label();
            lblSalvar = new Label();
            lblExcluir = new Label();
            lblAlterar = new Label();
            lblLocalizar = new Label();
            lblInserir = new Label();
            btCancelar = new Button();
            btSalvar = new Button();
            btExcluir = new Button();
            btAlterar = new Button();
            btLocalizar = new Button();
            btInserir = new Button();
            pDados.SuspendLayout();
            pMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pDados
            // 
            pDados.Controls.Add(txtTelefone);
            pDados.Controls.Add(lblTelefone);
            pDados.Controls.Add(txtEmail);
            pDados.Controls.Add(lblEmail);
            pDados.Controls.Add(txtCep);
            pDados.Controls.Add(lblCep);
            pDados.Controls.Add(txtEstado);
            pDados.Controls.Add(lblEstado);
            pDados.Controls.Add(txtCidade);
            pDados.Controls.Add(lblCidade);
            pDados.Controls.Add(txtBairro);
            pDados.Controls.Add(lblBairro);
            pDados.Controls.Add(txtEndereco);
            pDados.Controls.Add(lblEndereco);
            pDados.Controls.Add(txtNome);
            pDados.Controls.Add(lblNome);
            pDados.Controls.Add(txtCodigo);
            pDados.Controls.Add(lblCodigo);
            pDados.Location = new Point(12, 12);
            pDados.Name = "pDados";
            pDados.Size = new Size(758, 398);
            pDados.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(0, 79);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(223, 27);
            txtTelefone.TabIndex = 2;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Open Sans", 9F);
            lblTelefone.Location = new Point(0, 56);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(69, 22);
            lblTelefone.TabIndex = 16;
            lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(229, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(507, 27);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Open Sans", 9F);
            lblEmail.Location = new Point(226, 56);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 22);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(499, 258);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(125, 27);
            txtCep.TabIndex = 8;
            txtCep.TextChanged += txtCep_TextChanged;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Open Sans", 9F);
            lblCep.Location = new Point(499, 235);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(36, 22);
            lblCep.TabIndex = 12;
            lblCep.Text = "CEP";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(368, 258);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(125, 27);
            txtEstado.TabIndex = 7;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Open Sans", 9F);
            lblEstado.Location = new Point(365, 235);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(56, 22);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Estado";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(-3, 258);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(365, 27);
            txtCidade.TabIndex = 6;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Open Sans", 9F);
            lblCidade.Location = new Point(0, 235);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(57, 22);
            lblCidade.TabIndex = 8;
            lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(368, 194);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(365, 27);
            txtBairro.TabIndex = 5;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Open Sans", 9F);
            lblBairro.Location = new Point(368, 169);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(53, 22);
            lblBairro.TabIndex = 6;
            lblBairro.Text = "Bairro";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(-3, 194);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(365, 27);
            txtEndereco.TabIndex = 4;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Open Sans", 9F);
            lblEndereco.Location = new Point(0, 169);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(74, 22);
            lblEndereco.TabIndex = 4;
            lblEndereco.Text = "Endereço";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(134, 23);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(602, 27);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Open Sans", 9F);
            lblNome.Location = new Point(131, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(52, 22);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(0, 23);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Open Sans", 9F);
            lblCodigo.Location = new Point(-3, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 22);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // pMenu
            // 
            pMenu.Controls.Add(lblCancelar);
            pMenu.Controls.Add(lblSalvar);
            pMenu.Controls.Add(lblExcluir);
            pMenu.Controls.Add(lblAlterar);
            pMenu.Controls.Add(lblLocalizar);
            pMenu.Controls.Add(lblInserir);
            pMenu.Controls.Add(btCancelar);
            pMenu.Controls.Add(btSalvar);
            pMenu.Controls.Add(btExcluir);
            pMenu.Controls.Add(btAlterar);
            pMenu.Controls.Add(btLocalizar);
            pMenu.Controls.Add(btInserir);
            pMenu.Location = new Point(12, 416);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(758, 125);
            pMenu.TabIndex = 1;
            // 
            // lblCancelar
            // 
            lblCancelar.AutoSize = true;
            lblCancelar.Font = new Font("Open Sans", 9F);
            lblCancelar.Location = new Point(652, -1);
            lblCancelar.Name = "lblCancelar";
            lblCancelar.Size = new Size(69, 22);
            lblCancelar.TabIndex = 11;
            lblCancelar.Text = "Cancelar";
            // 
            // lblSalvar
            // 
            lblSalvar.AutoSize = true;
            lblSalvar.Font = new Font("Open Sans", 9F);
            lblSalvar.Location = new Point(467, -1);
            lblSalvar.Name = "lblSalvar";
            lblSalvar.Size = new Size(51, 22);
            lblSalvar.TabIndex = 10;
            lblSalvar.Text = "Salvar";
            // 
            // lblExcluir
            // 
            lblExcluir.AutoSize = true;
            lblExcluir.Font = new Font("Open Sans", 9F);
            lblExcluir.Location = new Point(360, -1);
            lblExcluir.Name = "lblExcluir";
            lblExcluir.Size = new Size(56, 22);
            lblExcluir.TabIndex = 9;
            lblExcluir.Text = "Excluir";
            // 
            // lblAlterar
            // 
            lblAlterar.AutoSize = true;
            lblAlterar.Font = new Font("Open Sans", 9F);
            lblAlterar.Location = new Point(248, -1);
            lblAlterar.Name = "lblAlterar";
            lblAlterar.Size = new Size(56, 22);
            lblAlterar.TabIndex = 8;
            lblAlterar.Text = "Alterar";
            // 
            // lblLocalizar
            // 
            lblLocalizar.AutoSize = true;
            lblLocalizar.Font = new Font("Open Sans", 9F);
            lblLocalizar.Location = new Point(145, 0);
            lblLocalizar.Name = "lblLocalizar";
            lblLocalizar.Size = new Size(71, 22);
            lblLocalizar.TabIndex = 7;
            lblLocalizar.Text = "Localizar";
            // 
            // lblInserir
            // 
            lblInserir.AutoSize = true;
            lblInserir.Font = new Font("Open Sans", 9F);
            lblInserir.Location = new Point(37, 0);
            lblInserir.Name = "lblInserir";
            lblInserir.Size = new Size(54, 22);
            lblInserir.TabIndex = 6;
            lblInserir.Text = "Inserir";
            // 
            // btCancelar
            // 
            btCancelar.Image = Properties.Resources.Cancelar100x100;
            btCancelar.Location = new Point(636, 22);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(100, 100);
            btCancelar.TabIndex = 14;
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btSalvar
            // 
            btSalvar.Image = Properties.Resources.Salvar100x100;
            btSalvar.Location = new Point(441, 25);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(100, 100);
            btSalvar.TabIndex = 13;
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Image = Properties.Resources.Excluir100x100;
            btExcluir.Location = new Point(335, 22);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(100, 100);
            btExcluir.TabIndex = 12;
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // btAlterar
            // 
            btAlterar.Image = Properties.Resources.Alterar100x100;
            btAlterar.Location = new Point(229, 22);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(100, 100);
            btAlterar.TabIndex = 11;
            btAlterar.UseVisualStyleBackColor = true;
            btAlterar.Click += btAlterar_Click;
            // 
            // btLocalizar
            // 
            btLocalizar.Image = Properties.Resources.Localizar100x100;
            btLocalizar.Location = new Point(123, 22);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(100, 100);
            btLocalizar.TabIndex = 10;
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // btInserir
            // 
            btInserir.Image = Properties.Resources.Inserir100x100;
            btInserir.Location = new Point(12, 22);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(100, 100);
            btInserir.TabIndex = 9;
            btInserir.UseVisualStyleBackColor = true;
            btInserir.Click += btInserir_Click;
            // 
            // frmCadastroContato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(pMenu);
            Controls.Add(pDados);
            Name = "frmCadastroContato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Contatos";
            Load += frmCadastroContato_Load;
            pDados.ResumeLayout(false);
            pDados.PerformLayout();
            pMenu.ResumeLayout(false);
            pMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pDados;
        private Panel pMenu;
        private Button btCancelar;
        private Button btSalvar;
        private Button btExcluir;
        private Button btAlterar;
        private Button btLocalizar;
        private Button btInserir;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtCep;
        private Label lblCep;
        private TextBox txtEstado;
        private Label lblEstado;
        private TextBox txtCidade;
        private Label lblCidade;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblCancelar;
        private Label lblSalvar;
        private Label lblExcluir;
        private Label lblAlterar;
        private Label lblLocalizar;
        private Label lblInserir;
    }
}