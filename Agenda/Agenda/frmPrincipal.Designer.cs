namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btContato = new Button();
            SuspendLayout();
            // 
            // btContato
            // 
            btContato.Location = new Point(12, 12);
            btContato.Name = "btContato";
            btContato.Size = new Size(161, 73);
            btContato.TabIndex = 0;
            btContato.Text = "Contato";
            btContato.UseVisualStyleBackColor = true;
            btContato.Click += btContato_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(btContato);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda";
            ResumeLayout(false);
        }

        #endregion

        private Button btContato;
    }
}
