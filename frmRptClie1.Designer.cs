namespace SistemaLojaGames
{
    partial class frmRptClie1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptSimples = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClassClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClassClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptSimples
            // 
            reportDataSource1.Name = "dsClienteSimples";
            reportDataSource1.Value = this.ClassClienteBindingSource;
            this.rptSimples.LocalReport.DataSources.Add(reportDataSource1);
            this.rptSimples.LocalReport.ReportEmbeddedResource = "SistemaLojaGames.rptClientes1.rdlc";
            this.rptSimples.Location = new System.Drawing.Point(0, 0);
            this.rptSimples.Name = "rptSimples";
            this.rptSimples.Size = new System.Drawing.Size(823, 514);
            this.rptSimples.TabIndex = 0;
            // 
            // ClassClienteBindingSource
            // 
            this.ClassClienteBindingSource.DataSource = typeof(SistemaLojaGames.ClassCliente);
            this.ClassClienteBindingSource.CurrentChanged += new System.EventHandler(this.ClassClienteBindingSource_CurrentChanged);
            // 
            // frmRptClie1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 511);
            this.Controls.Add(this.rptSimples);
            this.Name = "frmRptClie1";
            this.Text = "frmRptClie1";
            this.Load += new System.EventHandler(this.frmRptClie1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptSimples;
        private System.Windows.Forms.BindingSource ClassClienteBindingSource;
    }
}