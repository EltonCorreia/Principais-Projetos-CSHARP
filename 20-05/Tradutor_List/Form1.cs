namespace Tradutor_List
{
    public partial class Form1 : Form
    {
        List<String> listaPort = new List<String>();
        List<String> listaEng = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaPort.Add("casa");
            listaPort.Add("cachorro");
            listaPort.Add("gato");

            listaEng.Add("house");
            listaEng.Add("dog");
            listaEng.Add("cat");

         }

        private void btnTraduz_Click(object sender, EventArgs e)
        {
            String Texto = (txtport.Text);
            int pos = -1;
            for (int i = 0; i < listaPort.Count; i++)
            {
                if (Texto == listaPort.ElementAt(i))
                {
                    pos = i;
                    break;

                }
            }
            txteng.Text = listaEng[pos];
        }
    }
}
