namespace SistemaLojaGames
{
    partial class frmGerarRelatorio
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
            this.ClassClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.brGerar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RdInat = new System.Windows.Forms.RadioButton();
            this.RdFem = new System.Windows.Forms.RadioButton();
            this.RdAtiv = new System.Windows.Forms.RadioButton();
            this.RdMasc = new System.Windows.Forms.RadioButton();
            this.CbCidade = new System.Windows.Forms.ComboBox();
            this.TxtIdfin = new System.Windows.Forms.TextBox();
            this.TxtIdin = new System.Windows.Forms.TextBox();
            this.mskAno = new System.Windows.Forms.MaskedTextBox();
            this.mskDia = new System.Windows.Forms.MaskedTextBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.lbIdfin = new System.Windows.Forms.Label();
            this.LbCidade = new System.Windows.Forms.Label();
            this.lbIdin = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbDia = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbMes = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClassClienteBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassClienteBindingSource
            // 
            this.ClassClienteBindingSource.DataSource = typeof(SistemaLojaGames.ClassCliente);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Relatório:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Aniversariantes por Dia/Mês",
            "Aniversariantes do Mês",
            "Aniversariantes Data Completa",
            "Idade Mínima e Maxima",
            "Aniversariantes Maiores de",
            "Cidade",
            "Sexo",
            "Status"});
            this.cbTipo.Location = new System.Drawing.Point(12, 130);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(379, 28);
            this.cbTipo.TabIndex = 0;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // brGerar
            // 
            this.brGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brGerar.Location = new System.Drawing.Point(689, 105);
            this.brGerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brGerar.Name = "brGerar";
            this.brGerar.Size = new System.Drawing.Size(117, 97);
            this.brGerar.TabIndex = 2;
            this.brGerar.Text = "Gerar";
            this.brGerar.UseVisualStyleBackColor = true;
            this.brGerar.Click += new System.EventHandler(this.brGerar_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsClienteSimples";
            reportDataSource1.Value = this.ClassClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaLojaGames.rptClientes1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 208);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(794, 492);
            this.reportViewer1.TabIndex = 3;
            this.reportViewer1.ZoomPercent = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gameplay", 26.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(67, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(676, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "Emitir Relatorio de Clientes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RdInat);
            this.panel1.Controls.Add(this.RdFem);
            this.panel1.Controls.Add(this.RdAtiv);
            this.panel1.Controls.Add(this.RdMasc);
            this.panel1.Controls.Add(this.CbCidade);
            this.panel1.Controls.Add(this.TxtIdfin);
            this.panel1.Controls.Add(this.TxtIdin);
            this.panel1.Controls.Add(this.mskAno);
            this.panel1.Controls.Add(this.mskDia);
            this.panel1.Controls.Add(this.cbMes);
            this.panel1.Controls.Add(this.lbIdfin);
            this.panel1.Controls.Add(this.LbCidade);
            this.panel1.Controls.Add(this.lbIdin);
            this.panel1.Controls.Add(this.lbAno);
            this.panel1.Controls.Add(this.lbDia);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.lbSexo);
            this.panel1.Controls.Add(this.lbMes);
            this.panel1.Location = new System.Drawing.Point(398, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 97);
            this.panel1.TabIndex = 1;
            // 
            // RdInat
            // 
            this.RdInat.AutoSize = true;
            this.RdInat.Location = new System.Drawing.Point(139, 36);
            this.RdInat.Name = "RdInat";
            this.RdInat.Size = new System.Drawing.Size(76, 24);
            this.RdInat.TabIndex = 5;
            this.RdInat.TabStop = true;
            this.RdInat.Text = "Inativo";
            this.RdInat.UseVisualStyleBackColor = true;
            // 
            // RdFem
            // 
            this.RdFem.AutoSize = true;
            this.RdFem.Location = new System.Drawing.Point(161, 35);
            this.RdFem.Name = "RdFem";
            this.RdFem.Size = new System.Drawing.Size(92, 24);
            this.RdFem.TabIndex = 5;
            this.RdFem.TabStop = true;
            this.RdFem.Text = "Feminino";
            this.RdFem.UseVisualStyleBackColor = true;
            // 
            // RdAtiv
            // 
            this.RdAtiv.AutoSize = true;
            this.RdAtiv.Location = new System.Drawing.Point(68, 36);
            this.RdAtiv.Name = "RdAtiv";
            this.RdAtiv.Size = new System.Drawing.Size(65, 24);
            this.RdAtiv.TabIndex = 5;
            this.RdAtiv.TabStop = true;
            this.RdAtiv.Text = "Ativo";
            this.RdAtiv.UseVisualStyleBackColor = true;
            // 
            // RdMasc
            // 
            this.RdMasc.AutoSize = true;
            this.RdMasc.Location = new System.Drawing.Point(57, 34);
            this.RdMasc.Name = "RdMasc";
            this.RdMasc.Size = new System.Drawing.Size(98, 24);
            this.RdMasc.TabIndex = 5;
            this.RdMasc.TabStop = true;
            this.RdMasc.Text = "Masculino";
            this.RdMasc.UseVisualStyleBackColor = true;
            // 
            // CbCidade
            // 
            this.CbCidade.FormattingEnabled = true;
            this.CbCidade.Location = new System.Drawing.Point(72, 36);
            this.CbCidade.Name = "CbCidade";
            this.CbCidade.Size = new System.Drawing.Size(121, 28);
            this.CbCidade.TabIndex = 4;
            // 
            // TxtIdfin
            // 
            this.TxtIdfin.Location = new System.Drawing.Point(108, 46);
            this.TxtIdfin.MaxLength = 3;
            this.TxtIdfin.Name = "TxtIdfin";
            this.TxtIdfin.Size = new System.Drawing.Size(52, 27);
            this.TxtIdfin.TabIndex = 3;
            // 
            // TxtIdin
            // 
            this.TxtIdin.Location = new System.Drawing.Point(108, 14);
            this.TxtIdin.MaxLength = 3;
            this.TxtIdin.Name = "TxtIdin";
            this.TxtIdin.Size = new System.Drawing.Size(52, 27);
            this.TxtIdin.TabIndex = 3;
            // 
            // mskAno
            // 
            this.mskAno.Location = new System.Drawing.Point(53, 6);
            this.mskAno.Mask = "0000";
            this.mskAno.Name = "mskAno";
            this.mskAno.Size = new System.Drawing.Size(47, 27);
            this.mskAno.TabIndex = 2;
            // 
            // mskDia
            // 
            this.mskDia.Location = new System.Drawing.Point(53, 34);
            this.mskDia.Mask = "00";
            this.mskDia.Name = "mskDia";
            this.mskDia.Size = new System.Drawing.Size(23, 27);
            this.mskDia.TabIndex = 2;
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(53, 64);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 28);
            this.cbMes.TabIndex = 1;
            // 
            // lbIdfin
            // 
            this.lbIdfin.AutoSize = true;
            this.lbIdfin.Location = new System.Drawing.Point(4, 48);
            this.lbIdfin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdfin.Name = "lbIdfin";
            this.lbIdfin.Size = new System.Drawing.Size(89, 20);
            this.lbIdfin.TabIndex = 0;
            this.lbIdfin.Text = "Idade Final:";
            // 
            // LbCidade
            // 
            this.LbCidade.AutoSize = true;
            this.LbCidade.Location = new System.Drawing.Point(4, 39);
            this.LbCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbCidade.Name = "LbCidade";
            this.LbCidade.Size = new System.Drawing.Size(60, 20);
            this.LbCidade.TabIndex = 0;
            this.LbCidade.Text = "Cidade:";
            // 
            // lbIdin
            // 
            this.lbIdin.AutoSize = true;
            this.lbIdin.Location = new System.Drawing.Point(4, 17);
            this.lbIdin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdin.Name = "lbIdin";
            this.lbIdin.Size = new System.Drawing.Size(97, 20);
            this.lbIdin.TabIndex = 0;
            this.lbIdin.Text = "Idade Inicial:";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(4, 8);
            this.lbAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(42, 20);
            this.lbAno.TabIndex = 0;
            this.lbAno.Text = "Ano:";
            // 
            // lbDia
            // 
            this.lbDia.AutoSize = true;
            this.lbDia.Location = new System.Drawing.Point(4, 37);
            this.lbDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(36, 20);
            this.lbDia.TabIndex = 0;
            this.lbDia.Text = "Dia:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(4, 38);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(57, 20);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Status:";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(4, 36);
            this.lbSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(46, 20);
            this.lbSexo.TabIndex = 0;
            this.lbSexo.Text = "Sexo:";
            // 
            // lbMes
            // 
            this.lbMes.AutoSize = true;
            this.lbMes.Location = new System.Drawing.Point(4, 68);
            this.lbMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(42, 20);
            this.lbMes.TabIndex = 0;
            this.lbMes.Text = "Mês:";
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
            this.button2.Location = new System.Drawing.Point(785, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 17;
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
            this.button1.Location = new System.Drawing.Point(747, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Gameplay", 26.25F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(426, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 43);
            this.label19.TabIndex = 18;
            this.label19.Text = "\'";
            // 
            // frmGerarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(818, 712);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.brGerar);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGerarRelatorio";
            this.Text = "frmGerarRelatorio";
            this.Load += new System.EventHandler(this.frmGerarRelatorio_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastar);
            ((System.ComponentModel.ISupportInitialize)(this.ClassClienteBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button brGerar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClassClienteBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label lbMes;
        private System.Windows.Forms.MaskedTextBox mskDia;
        private System.Windows.Forms.Label lbDia;
        private System.Windows.Forms.MaskedTextBox mskAno;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbIdfin;
        private System.Windows.Forms.Label lbIdin;
        private System.Windows.Forms.TextBox TxtIdfin;
        private System.Windows.Forms.TextBox TxtIdin;
        private System.Windows.Forms.ComboBox CbCidade;
        private System.Windows.Forms.Label LbCidade;
        private System.Windows.Forms.RadioButton RdFem;
        private System.Windows.Forms.RadioButton RdMasc;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.RadioButton RdInat;
        private System.Windows.Forms.RadioButton RdAtiv;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
    }
}