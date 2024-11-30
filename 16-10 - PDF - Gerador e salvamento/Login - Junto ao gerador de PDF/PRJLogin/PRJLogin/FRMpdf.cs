using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENSOES
using iTextSharp.text;//EXTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//EXTENSAO 2 (PDF)
using System.IO;// A BIBLIOTECA DE ENTRADA E SAIDA DE ARQUIVOS

namespace PRJLogin
{
    public partial class FRMpdf : Form
    {
        ClasseConexao conn = new ClasseConexao();
        String caminho_escolhido = "";
        public FRMpdf()
        {
            InitializeComponent();
        }

        //PREPARA A FORMATAÇÃO DO CABEÇALHO
        private static void AddCellToHeader(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 10,
                BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255)
            });
        }

        //PREENCHE O CORPO DO DOCUMENTO
        protected PdfPTable corpo_documento(PdfPTable tableLayout)
        {
            float[] headers = { 10, 20, 10, 40, 30 }; //largura de cada campo
            tableLayout.SetWidths(headers); //Set the pdf headers 
            tableLayout.WidthPercentage = 100; //Set the PDF File witdh percentage 
            tableLayout.HeaderRows = 1;
            //Add header 
            AddCellToHeader(tableLayout, "ID");
            AddCellToHeader(tableLayout, "NOME");
            AddCellToHeader(tableLayout, "SENHA");
            AddCellToHeader(tableLayout, "ENDERECO");
            AddCellToHeader(tableLayout, "CARGO");
            //AddCellToHeader(tableLayout, "CEP");
            //Add body
            DataTable dt = new DataTable();
            dt = conn.executarSQL("SELECT * FROM contatos");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AddCellToBody(tableLayout, dt.Rows[i]["id"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["nome"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["senha"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["endereco"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["cargo"].ToString(), i);
                //AddCellToBody(tableLayout, "044444", i); //valor fixo, sem DB
            }
            return tableLayout;
        }

        //PREENCHE AS LINHAS DO BODY COM TONS DE BRANCO E CINZA, INTERCALADO
        private static void AddCellToBody(PdfPTable tableLayout, string cellText, int count) //Efeito fundo: cinza e claro
        {
            if (count % 2 == 0)
            {
                tableLayout.AddCell(new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA, 8, 1, iTextSharp.text.BaseColor.BLACK)))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    Padding = 8,
                    BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255)
                });
            }
            else
            {
                tableLayout.AddCell(new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA, 8, 1, iTextSharp.text.BaseColor.BLACK)))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    Padding = 8,
                    BackgroundColor = new iTextSharp.text.BaseColor(230, 230, 230)
                });
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar PDF como";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            caminho_escolhido = saveFileDialog1.FileName;
            MessageBox.Show("Salvo em: " + caminho_escolhido);
            Document doc = null;
            try
            {
                //criando o arquivo pdf
                doc = new Document(PageSize.A4);//tipo da folha usada
                doc.SetMargins(10, 10, 10, 10);//estibulando o espaçamento das margens que queremos
                doc.AddCreationDate();//adicionando as configuracoes
                //string caminho_escolhido = @"C:\Users\Lab ETESP\Desktop\" + "TESTE3.pdf";
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho_escolhido, FileMode.Create));
                doc.Open();

                PdfPTable tableLayout = new PdfPTable(5); //qtde de colunas do relatório
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font fontInvoice = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.NORMAL);
                Paragraph paragraph = new Paragraph("Dados - Clientes", fontInvoice);
                paragraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(paragraph);
                Paragraph p3 = new Paragraph();
                p3.SpacingAfter = 6;
                doc.Add(p3);
                doc.Add(corpo_documento(tableLayout));
                doc.Close();
            }
            catch (Exception erro)
            {
                if (doc != null)
                    doc.Close();
                MessageBox.Show("Erro Arquivo PDF --> " + erro);
            }
        }
    }
}
