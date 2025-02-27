namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btContato_Click(object sender, EventArgs e)
        {
            frmCadastroContato f = new frmCadastroContato();
            f.ShowDialog();
            f.Dispose(); //Elimina o formulario para liberar memória.
        }
    }
}
