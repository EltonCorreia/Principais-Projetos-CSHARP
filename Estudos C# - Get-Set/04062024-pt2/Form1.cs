namespace _04062024_pt2
{
    public partial class Form1 : Form
    {
        Avançar x = new Avançar();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            
            if(rdrP1Sim.Checked)
            {
                Form2 p2 = new Form2();
                p2.Show();
            }
            else
            {
               
            }
           
        }
    }
}
