namespace Avaliação_C____Nome_Sobrenome
{
    public partial class Form1 : Form
    {

        Avançar x = new Avançar();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {

            x.setnome(txtNome.Text);

            Form2 f2 = new Form2();
            f2.Show();

        }
    }
}
