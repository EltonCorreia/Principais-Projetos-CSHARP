namespace Quizz3
{
    public partial class Question1 : Form
    {
        Ponte cp = new Ponte();
        public Question1()
        {
            InitializeComponent();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            cp.setNome("Pgt1");

            Question2 frn2 = new Question2();
            frn2.ShowDialog();



        }

        private void rB3_CheckedChanged(object sender, EventArgs e)
        {
            cp.setContar(1);
        }
    }
}
