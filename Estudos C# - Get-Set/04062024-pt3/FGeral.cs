namespace _04062024_pt3
{
    public partial class FGeral : Form
    {

        Avançar x = new Avançar();

        public FGeral()
        {
            InitializeComponent();
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {

            if(rdrA1.Checked)
            {
               A1 a1 = new A1();
               a1.Show();
            }


            if (rdrA2.Checked)
            {
                A2 a2 = new A2();
                a2.Show();
            }


            if (rdrA3.Checked)
            {
                A3 a3 = new A3();
                a3.Show();
            }

        }
    }
}
