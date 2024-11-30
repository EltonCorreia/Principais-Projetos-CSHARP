namespace Exercício___Get_Set
{
    public partial class Form1 : Form
    {

        Avançar x = new Avançar();

        int v1, v2, soma;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnV1_Click(object sender, EventArgs e)
        {
            
           int v1 = int.Parse(txtValor1.Text);
           x.setf1(v1);
           
           Form2 f2 = new Form2();
           f2.Show();

        }
    }
}
