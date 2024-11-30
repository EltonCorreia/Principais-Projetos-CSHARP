namespace _01062024
{
    public partial class Form1 : Form
    {

        //Adicionar a classe ao Form

        Receber x = new Receber();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            x.setNome(txtUser.Text);

            x.setIdade(txtIdade.Text);

            x.sethobby(txtHobby.Text);

            Form2 f2 = new Form2();
            f2.Show();

        }
    }
}
