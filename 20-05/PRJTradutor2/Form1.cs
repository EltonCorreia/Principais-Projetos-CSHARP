namespace PRJTradutor2
{
    public partial class Form1 : Form
    {
        List<int> textP = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraduzir_Click(object sender, EventArgs e)
        {
            String[] port = new String[] { "mesa", "cadeira", "lua" };
            String[] ingl = new String[] { "table", "chair", "moon" };
            String dig = txtP.Text;
            dig = dig.ToLower().ToLower();
            int pos = 0;
            for (int i = 0; i < port.Length; i++) 
            if (dig.Equals(port[i]))
                {
                    pos = i;
                    break;
                }
            txtRes.Text = ingl[pos];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
