using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjConexao1
{
    public partial class FRMLocalizar : Form
    {

        ClasseConexao con;
        DataTable dt;
        Compartilha cp = new Compartilha();

        public FRMLocalizar()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM contatos WHERE nome LIKE '%" + txtLocalizar.Text + "%'";
            con = new ClasseConexao();
            dt = con.executarSQL(sql);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                String id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cp.setId(id);
            }
        }

        private void formatarGrid()
        {
            dataGridView1.Columns[0].Visible = false; //esconde a coluna ID
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.AllowUserToAddRows = false; //ESCONDE A NOVA LINHA DO GRID
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false; //ESCONDE O PONTEIRO DO GRID
            dataGridView1.ReadOnly = true;
            //permite personalizar o grid
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera a cor das linhas alternadas no grid
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            //altera o nome das colunas
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "NOME";
            dataGridView1.Columns[2].HeaderText = "FONE";
            //grid.Columns[3].HeaderText = "PREÇO UNITÁRIO";
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 80;
            //não permite seleção de multiplas linhas    
            dataGridView1.MultiSelect = false;
            //ao clicar, seleciona a linha inteira
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Expande a célula automáticamente
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

    }
}
