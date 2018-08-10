namespace SistemaLojaGames
{
    partial class frmRptVenda
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
            this.ClassRelatorioVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtCodC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btPesqClie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.DtInicial = new System.Windows.Forms.DateTimePicker();
            this.DtFinal = new System.Windows.Forms.DateTimePicker();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClassRelatorioVBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassRelatorioVBindingSource
            // 
            this.ClassRelatorioVBindingSource.DataSource = typeof(SistemaLojaGames.ClassRelatorioV);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClassRelatorioVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaLojaGames.rptVendaD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(19, 323);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(729, 280);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtCodC
            // 
            this.txtCodC.Enabled = false;
            this.txtCodC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCodC.Location = new System.Drawing.Point(153, 152);
            this.txtCodC.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCodC.Name = "txtCodC";
            this.txtCodC.Size = new System.Drawing.Size(65, 29);
            this.txtCodC.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Código do Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código da Venda:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodV
            // 
            this.txtCodV.Enabled = false;
            this.txtCodV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCodV.Location = new System.Drawing.Point(505, 152);
            this.txtCodV.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCodV.Name = "txtCodV";
            this.txtCodV.Size = new System.Drawing.Size(89, 29);
            this.txtCodV.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gameplay", 26.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(71, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(756, 53);
            this.label6.TabIndex = 23;
            this.label6.Text = "Emitir Relatorio de Venda";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPesqClie
            // 
            this.btPesqClie.Enabled = false;
            this.btPesqClie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqClie.Location = new System.Drawing.Point(228, 149);
            this.btPesqClie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPesqClie.Name = "btPesqClie";
            this.btPesqClie.Size = new System.Drawing.Size(139, 30);
            this.btPesqClie.TabIndex = 2;
            this.btPesqClie.Text = "Pesquisar";
            this.btPesqClie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPesqClie.UseVisualStyleBackColor = true;
            this.btPesqClie.Click += new System.EventHandler(this.btPesqClie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tipo de pesquisa:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Cliente",
            "Venda",
            "Período",
            "Funcionário",
            "Funcionário por Período",
            "Cliente por Período"});
            this.cbTipo.Location = new System.Drawing.Point(153, 111);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(441, 32);
            this.cbTipo.TabIndex = 0;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // DtInicial
            // 
            this.DtInicial.Enabled = false;
            this.DtInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DtInicial.Location = new System.Drawing.Point(9, 33);
            this.DtInicial.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DtInicial.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtInicial.Name = "DtInicial";
            this.DtInicial.Size = new System.Drawing.Size(342, 29);
            this.DtInicial.TabIndex = 0;
            this.DtInicial.Value = new System.DateTime(2018, 3, 29, 0, 0, 0, 0);
            // 
            // DtFinal
            // 
            this.DtFinal.Enabled = false;
            this.DtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DtFinal.Location = new System.Drawing.Point(361, 33);
            this.DtFinal.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DtFinal.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtFinal.Name = "DtFinal";
            this.DtFinal.Size = new System.Drawing.Size(359, 29);
            this.DtFinal.TabIndex = 1;
            this.DtFinal.Value = new System.DateTime(2018, 3, 29, 0, 0, 0, 0);
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(153, 188);
            this.cbFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(441, 32);
            this.cbFuncionario.TabIndex = 4;
            this.cbFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::SistemaLojaGames.Properties.Resources.pixel_icons;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(734, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SistemaLojaGames.Properties.Resources.pixel_icons2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(697, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Funcionário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data Inicial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Data Final:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DtInicial);
            this.panel1.Controls.Add(this.DtFinal);
            this.panel1.Location = new System.Drawing.Point(15, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 75);
            this.panel1.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Gameplay", 26.25F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(365, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 53);
            this.label19.TabIndex = 28;
            this.label19.Text = "\'";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(601, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 105);
            this.button3.TabIndex = 29;
            this.button3.Text = "Gerar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // frmRptVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(767, 623);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btPesqClie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txtCodV);
            this.Controls.Add(this.txtCodC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label19);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRptVenda";
            this.Text = "frmRptVenda";
            this.Load += new System.EventHandler(this.frmRptVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassRelatorioVBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClassRelatorioVBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btPesqClie;
        public System.Windows.Forms.TextBox txtCodC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.DateTimePicker DtInicial;
        private System.Windows.Forms.DateTimePicker DtFinal;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button3;
    }
}