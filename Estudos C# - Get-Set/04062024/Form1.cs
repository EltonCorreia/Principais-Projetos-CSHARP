namespace _04062024
{
    public partial class Form1 : Form
    {

        Receber x = new Receber();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            x.setMensagem(txtMensagem.Text);

            Form2 f2 = new Form2();
            f2.Show();

        }
    }
}
