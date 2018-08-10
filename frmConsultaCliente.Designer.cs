namespace SistemaLojaGames
{
    partial class frmConsultaCliente
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
            this.txtPes = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rdInat = new System.Windows.Forms.RadioButton();
            this.rdAtiv = new System.Windows.Forms.RadioButton();
            this.btPesq = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.dgRes = new System.Windows.Forms.DataGridView();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEst = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btRpt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPes
            // 
            this.txtPes.Enabled = false;
            this.txtPes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPes.Location = new System.Drawing.Point(303, 99);
            this.txtPes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPes.Name = "txtPes";
            this.txtPes.Size = new System.Drawing.Size(578, 24);
            this.txtPes.TabIndex = 1;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Status",
            "Nome",
            "Estado",
            "CPF",
            "Codigo"});
            this.cbTipo.Location = new System.Drawing.Point(13, 97);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(280, 26);
            this.cbTipo.TabIndex = 0;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rdInat);
            this.gbStatus.Controls.Add(this.rdAtiv);
            this.gbStatus.Enabled = false;
            this.gbStatus.Location = new System.Drawing.Point(399, 129);
            this.gbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStatus.Size = new System.Drawing.Size(300, 66);
            this.gbStatus.TabIndex = 5;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rdInat
            // 
            this.rdInat.AutoSize = true;
            this.rdInat.Location = new System.Drawing.Point(147, 29);
            this.rdInat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdInat.Name = "rdInat";
            this.rdInat.Size = new System.Drawing.Size(76, 24);
            this.rdInat.TabIndex = 1;
            this.rdInat.Text = "Inatívo";
            this.rdInat.UseVisualStyleBackColor = true;
            // 
            // rdAtiv
            // 
            this.rdAtiv.AutoSize = true;
            this.rdAtiv.Location = new System.Drawing.Point(10, 29);
            this.rdAtiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdAtiv.Name = "rdAtiv";
            this.rdAtiv.Size = new System.Drawing.Size(65, 24);
            this.rdAtiv.TabIndex = 0;
            this.rdAtiv.Text = "Ativo";
            this.rdAtiv.UseVisualStyleBackColor = true;
            // 
            // btPesq
            // 
            this.btPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesq.Location = new System.Drawing.Point(735, 129);
            this.btPesq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPesq.Name = "btPesq";
            this.btPesq.Size = new System.Drawing.Size(146, 66);
            this.btPesq.TabIndex = 6;
            this.btPesq.Text = "Pesquisar";
            this.btPesq.UseVisualStyleBackColor = true;
            this.btPesq.Click += new System.EventHandler(this.btPesq_Click);
            // 
            // btDel
            // 
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDel.ImageKey = "(none)";
            this.btDel.Location = new System.Drawing.Point(641, 622);
            this.btDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(116, 62);
            this.btDel.TabIndex = 7;
            this.btDel.Text = "Excluir";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btEdit
            // 
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdit.Location = new System.Drawing.Point(765, 622);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(116, 62);
            this.btEdit.TabIndex = 9;
            this.btEdit.Text = "Editar";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // dgRes
            // 
            this.dgRes.AllowUserToAddRows = false;
            this.dgRes.AllowUserToDeleteRows = false;
            this.dgRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRes.Location = new System.Drawing.Point(13, 202);
            this.dgRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgRes.MultiSelect = false;
            this.dgRes.Name = "dgRes";
            this.dgRes.ReadOnly = true;
            this.dgRes.RowHeadersVisible = false;
            this.dgRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRes.Size = new System.Drawing.Size(869, 411);
            this.dgRes.TabIndex = 14;
            // 
            // mskCpf
            // 
            this.mskCpf.Enabled = false;
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mskCpf.Location = new System.Drawing.Point(14, 156);
            this.mskCpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(113, 24);
            this.mskCpf.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo de pesquisa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nome:";
            // 
            // cbEst
            // 
            this.cbEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEst.Enabled = false;
            this.cbEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbEst.FormattingEnabled = true;
            this.cbEst.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbEst.Location = new System.Drawing.Point(146, 156);
            this.cbEst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEst.Name = "cbEst";
            this.cbEst.Size = new System.Drawing.Size(97, 26);
            this.cbEst.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Estado:";
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCod.Location = new System.Drawing.Point(253, 158);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(138, 24);
            this.txtCod.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gameplay", 26.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(191, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(520, 43);
            this.label6.TabIndex = 18;
            this.label6.Text = "Consulta de Clientes";
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
            this.button2.Location = new System.Drawing.Point(867, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btRpt
            // 
            this.btRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRpt.Location = new System.Drawing.Point(765, 622);
            this.btRpt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRpt.Name = "btRpt";
            this.btRpt.Size = new System.Drawing.Size(116, 62);
            this.btRpt.TabIndex = 8;
            this.btRpt.Text = "Escolher";
            this.btRpt.UseVisualStyleBackColor = true;
            this.btRpt.Visible = false;
            this.btRpt.Click += new System.EventHandler(this.btRpt_Click);
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
            this.button1.Location = new System.Drawing.Point(829, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.txtPes);
            this.Controls.Add(this.cbEst);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.btPesq);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btRpt);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.dgRes);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultaCliente";
            this.Text = "Consulta de Clientes";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastar);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPes;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rdInat;
        private System.Windows.Forms.RadioButton rdAtiv;
        private System.Windows.Forms.Button btPesq;
        private System.Windows.Forms.DataGridView dgRes;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btDel;
        public System.Windows.Forms.Button btEdit;
        public System.Windows.Forms.Button btRpt;
        private System.Windows.Forms.Button button1;
    }
}