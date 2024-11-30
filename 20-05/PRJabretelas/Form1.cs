namespace PRJabretelas
{
    public partial class Form1 : Form
    {
       Compartilha cp  = new Compartilha();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cp.setNome("ETESP");
            
             Form2 frn2 = new Form2();
          frn2.Show();
            //show permite abrir varios do mesmo
            //showDialog Só permite abrir um

        }
    }
}
