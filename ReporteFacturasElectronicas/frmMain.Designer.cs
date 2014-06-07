namespace ReporteFacturasElectronicas
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.seleccionaArchivo = new System.Windows.Forms.Button();
            this.procesaArchivo = new System.Windows.Forms.Button();
            this.tbArchivoPDF = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FolioFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFCEmisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocialEmisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFCReceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocialReceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PACCertifico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCertificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EfectoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbArchivoGenerar = new System.Windows.Forms.TextBox();
            this.generarArchivo = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // seleccionaArchivo
            // 
            this.seleccionaArchivo.Location = new System.Drawing.Point(1026, 32);
            this.seleccionaArchivo.Name = "seleccionaArchivo";
            this.seleccionaArchivo.Size = new System.Drawing.Size(75, 23);
            this.seleccionaArchivo.TabIndex = 0;
            this.seleccionaArchivo.Text = "Seleccionar Archivo";
            this.seleccionaArchivo.UseVisualStyleBackColor = true;
            this.seleccionaArchivo.Click += new System.EventHandler(this.seleccionaArchivo_Click);
            // 
            // procesaArchivo
            // 
            this.procesaArchivo.Location = new System.Drawing.Point(1113, 33);
            this.procesaArchivo.Name = "procesaArchivo";
            this.procesaArchivo.Size = new System.Drawing.Size(75, 23);
            this.procesaArchivo.TabIndex = 1;
            this.procesaArchivo.Text = "Procesar";
            this.procesaArchivo.UseVisualStyleBackColor = true;
            this.procesaArchivo.Click += new System.EventHandler(this.procesaArchivo_Click);
            // 
            // tbArchivoPDF
            // 
            this.tbArchivoPDF.Location = new System.Drawing.Point(25, 35);
            this.tbArchivoPDF.Name = "tbArchivoPDF";
            this.tbArchivoPDF.Size = new System.Drawing.Size(986, 20);
            this.tbArchivoPDF.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FolioFiscal,
            this.RFCEmisor,
            this.RazonSocialEmisor,
            this.RFCReceptor,
            this.RazonSocialReceptor,
            this.PACCertifico,
            this.Total,
            this.FechaEmision,
            this.FechaCertificacion,
            this.EstadoComprobante,
            this.EfectoComprobante});
            this.dataGridView1.Location = new System.Drawing.Point(25, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1163, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // FolioFiscal
            // 
            this.FolioFiscal.HeaderText = "Folio Fiscal";
            this.FolioFiscal.Name = "FolioFiscal";
            // 
            // RFCEmisor
            // 
            this.RFCEmisor.HeaderText = "RFC Emisor";
            this.RFCEmisor.Name = "RFCEmisor";
            // 
            // RazonSocialEmisor
            // 
            this.RazonSocialEmisor.HeaderText = "Razón Social Emisor";
            this.RazonSocialEmisor.Name = "RazonSocialEmisor";
            // 
            // RFCReceptor
            // 
            this.RFCReceptor.HeaderText = "RFC Receptor";
            this.RFCReceptor.Name = "RFCReceptor";
            // 
            // RazonSocialReceptor
            // 
            this.RazonSocialReceptor.HeaderText = "Razón Social Receptor";
            this.RazonSocialReceptor.Name = "RazonSocialReceptor";
            // 
            // PACCertifico
            // 
            this.PACCertifico.HeaderText = "PAC que Certificó";
            this.PACCertifico.Name = "PACCertifico";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // FechaEmision
            // 
            this.FechaEmision.HeaderText = "Fecha Emisión";
            this.FechaEmision.Name = "FechaEmision";
            // 
            // FechaCertificacion
            // 
            this.FechaCertificacion.HeaderText = "Fecha Certificación";
            this.FechaCertificacion.Name = "FechaCertificacion";
            // 
            // EstadoComprobante
            // 
            this.EstadoComprobante.HeaderText = "Estado del Comprobante";
            this.EstadoComprobante.Name = "EstadoComprobante";
            // 
            // EfectoComprobante
            // 
            this.EfectoComprobante.HeaderText = "Efecto del Comprobante";
            this.EfectoComprobante.Name = "EfectoComprobante";
            // 
            // tbArchivoGenerar
            // 
            this.tbArchivoGenerar.Location = new System.Drawing.Point(25, 245);
            this.tbArchivoGenerar.Name = "tbArchivoGenerar";
            this.tbArchivoGenerar.Size = new System.Drawing.Size(986, 20);
            this.tbArchivoGenerar.TabIndex = 4;
            // 
            // generarArchivo
            // 
            this.generarArchivo.Location = new System.Drawing.Point(1026, 243);
            this.generarArchivo.Name = "generarArchivo";
            this.generarArchivo.Size = new System.Drawing.Size(117, 23);
            this.generarArchivo.TabIndex = 5;
            this.generarArchivo.Text = "Generar Archivo";
            this.generarArchivo.UseVisualStyleBackColor = true;
            this.generarArchivo.Click += new System.EventHandler(this.generarArchivo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 293);
            this.Controls.Add(this.generarArchivo);
            this.Controls.Add(this.tbArchivoGenerar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbArchivoPDF);
            this.Controls.Add(this.procesaArchivo);
            this.Controls.Add(this.seleccionaArchivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Reporte de Facturas Electrónicas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seleccionaArchivo;
        private System.Windows.Forms.Button procesaArchivo;
        private System.Windows.Forms.TextBox tbArchivoPDF;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolioFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFCEmisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocialEmisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFCReceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocialReceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACCertifico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCertificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn EfectoComprobante;
        private System.Windows.Forms.TextBox tbArchivoGenerar;
        private System.Windows.Forms.Button generarArchivo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

