namespace Agenda
{
    partial class frmConsultaContatos
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
            lblNomeDoContato = new Label();
            txtValor = new TextBox();
            btLocalizar = new Button();
            dgDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgDados).BeginInit();
            SuspendLayout();
            // 
            // lblNomeDoContato
            // 
            lblNomeDoContato.AutoSize = true;
            lblNomeDoContato.Location = new Point(12, 9);
            lblNomeDoContato.Name = "lblNomeDoContato";
            lblNomeDoContato.Size = new Size(129, 20);
            lblNomeDoContato.TabIndex = 0;
            lblNomeDoContato.Text = "Nome do Contato";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(12, 32);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(658, 27);
            txtValor.TabIndex = 1;
            // 
            // btLocalizar
            // 
            btLocalizar.Location = new Point(676, 30);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(94, 29);
            btLocalizar.TabIndex = 2;
            btLocalizar.Text = "Localizar";
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // dgDados
            // 
            dgDados.AllowUserToAddRows = false;
            dgDados.AllowUserToDeleteRows = false;
            dgDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDados.Location = new Point(12, 65);
            dgDados.Name = "dgDados";
            dgDados.ReadOnly = true;
            dgDados.RowHeadersWidth = 51;
            dgDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDados.Size = new Size(758, 476);
            dgDados.TabIndex = 3;
            // 
            // frmConsultaContatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(dgDados);
            Controls.Add(btLocalizar);
            Controls.Add(txtValor);
            Controls.Add(lblNomeDoContato);
            Name = "frmConsultaContatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de contatos";
            ((System.ComponentModel.ISupportInitialize)dgDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeDoContato;
        private TextBox txtValor;
        private Button btLocalizar;
        private DataGridView dgDados;
    }
}