/*
 * Maco Antonio Lucio Rocha
 * 07JUN2014
 * Pograma para pasar el resultado de facturas electrónicas de hacienda a texto CSV,
 * para poder hacer reportes de este.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text.RegularExpressions;

namespace ReporteFacturasElectronicas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void seleccionaArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        tbArchivoPDF.Text = openFileDialog1.FileName;
                        tbArchivoGenerar.Text = Path.ChangeExtension(tbArchivoPDF.Text, ".csv");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se puede leer el archivo. Error original:" + ex.Message);
                }
            }
        }

        private void procesaArchivo_Click(object sender, EventArgs e)
        {
            if(tbArchivoPDF.Text != "" && File.Exists(tbArchivoPDF.Text))
            {
                Cursor.Current = Cursors.WaitCursor;
                ExtraerTextoDePDF(tbArchivoPDF.Text);
                Cursor.Current = Cursors.Default;
            }
        }

        public void ExtraerTextoDePDF(string pdfFile)
        {
            PdfReader reader = new PdfReader(pdfFile);
            int numeroDePaginas;
            string text = "";
            dataGridView1.Rows.Clear();

            numeroDePaginas = reader.NumberOfPages;
            for (int i = 0; i < numeroDePaginas; i++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, i + 1);
            }
            try { reader.Close(); }
            catch { }
            //text = text.Replace(System.Environment.NewLine, " ");
            //text = text.Replace("\n", " ");
            Regex regex = new Regex(@"Folio Fiscal: (?<FolioFiscal>[A-Z 0-9 \-]*)\s*" +
                @"RFC Emisor: (?<RFCEmisor>[A-Z 0-9]+)\s+" +
                @"Nombre o Razón Social: (?<RazonSocialEmisor>.*\n*.*)\s+" +
                @"RFC Receptor: (?<RFCReceptor>[A-Z 0-9]+)\s+" +
                @"Nombre o Razón Social: (?<RazonSocialReceptor>.*\n*.*)\s+" +
                @"PAC que Certificó: (?<PACCertifico>[A-Z 0-9]*)\s*" +
                @"Total: \$(?<Total>[0-9 , \.]*)\s*" +
                @"Fecha Emisión: (?<FechaEmision>[0-9 T \- \:]*)\s*" +
                @"Fecha Certificación: (?<FechaCertificacion>[0-9 T \- \:]*)\s*" +
                @"Estado del Comprobante: (?<EstadoComprobante>[A-Z a-z]*)\s*" +
                @"Efecto del Comprobante: (?<EfectoComprobante>[A-Z a-z]*)\s*");
            MatchCollection matches = regex.Matches(text);
            int j = 0;
            foreach (Match match in matches)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[j].Cells[0].Value = match.Groups["FolioFiscal"].Value;
                dataGridView1.Rows[j].Cells[1].Value = match.Groups["RFCEmisor"].Value;
                dataGridView1.Rows[j].Cells[2].Value = match.Groups["RazonSocialEmisor"].Value.Replace("\n","");
                dataGridView1.Rows[j].Cells[3].Value = match.Groups["RFCReceptor"].Value;
                dataGridView1.Rows[j].Cells[4].Value = match.Groups["RazonSocialReceptor"].Value.Replace("\n","");
                dataGridView1.Rows[j].Cells[5].Value = match.Groups["PACCertifico"].Value;
                dataGridView1.Rows[j].Cells[6].Value = match.Groups["Total"].Value;
                dataGridView1.Rows[j].Cells[7].Value = match.Groups["FechaEmision"].Value;
                dataGridView1.Rows[j].Cells[8].Value = match.Groups["FechaCertificacion"].Value;
                dataGridView1.Rows[j].Cells[9].Value = match.Groups["EstadoComprobante"].Value;
                dataGridView1.Rows[j].Cells[10].Value = match.Groups["EfectoComprobante"].Value;
                j++;
            }

        }

        private void generarArchivo_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter objWriter;

            if(tbArchivoGenerar.Text == "")
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("No se seleccionó un archivo.");                    
                }
                else
                {
                    tbArchivoGenerar.Text = saveFileDialog1.FileName;
                }
            }
            if(tbArchivoGenerar.Text != "" && dataGridView1.RowCount > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                objWriter = new System.IO.StreamWriter(tbArchivoGenerar.Text);

                for (int row = 0; row < dataGridView1.RowCount - 1; row++)
                {
                    int numCol = dataGridView1.Rows[row].Cells.Count;
                    for (int col=0;col<numCol; col++)
                    {
                        if (col == 2 || col == 4 || col == 6) { objWriter.Write("\""); }
                        objWriter.Write(dataGridView1.Rows[row].Cells[col].Value.ToString());
                        if (col == 2 || col == 4 || col == 6) { objWriter.Write("\""); }
                        objWriter.Write(",");
                    }
                    objWriter.WriteLine(""); // Salto de línea
                }

                objWriter.Close();
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Archivo generado.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
