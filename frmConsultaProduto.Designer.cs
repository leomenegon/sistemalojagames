namespace SistemaLojaGames
{
    partial class frmConsultaProduto
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
            this.btEdit = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.dgRes = new System.Windows.Forms.DataGridView();
            this.btPesq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPes = new System.Windows.Forms.TextBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.cbPlat = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rdInat = new System.Windows.Forms.RadioButton();
            this.rdAtiv = new System.Windows.Forms.RadioButton();
            this.gbVal = new System.Windows.Forms.GroupBox();
            this.txtVfi = new System.Windows.Forms.TextBox();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRes)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.gbVal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEdit
            // 
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdit.Location = new System.Drawing.Point(768, 614);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(116, 62);
            this.btEdit.TabIndex = 8;
            this.btEdit.Text = "Editar";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDel
            // 
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDel.ImageKey = "(none)";
            this.btDel.Location = new System.Drawing.Point(644, 614);
            this.btDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(116, 62);
            this.btDel.TabIndex = 7;
            this.btDel.Text = "Excluir";
            this.btDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // dgRes
            // 
            this.dgRes.AllowUserToAddRows = false;
            this.dgRes.AllowUserToDeleteRows = false;
            this.dgRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRes.Location = new System.Drawing.Point(13, 230);
            this.dgRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgRes.MultiSelect = false;
            this.dgRes.Name = "dgRes";
            this.dgRes.ReadOnly = true;
            this.dgRes.RowHeadersVisible = false;
            this.dgRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRes.Size = new System.Drawing.Size(871, 374);
            this.dgRes.TabIndex = 16;
            // 
            // btPesq
            // 
            this.btPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesq.Location = new System.Drawing.Point(734, 147);
            this.btPesq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPesq.Name = "btPesq";
            this.btPesq.Size = new System.Drawing.Size(149, 68);
            this.btPesq.TabIndex = 6;
            this.btPesq.Text = "Pesquisar";
            this.btPesq.UseVisualStyleBackColor = true;
            this.btPesq.Click += new System.EventHandler(this.btPesq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Plataforma:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Categoria:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPes
            // 
            this.txtPes.Enabled = false;
            this.txtPes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPes.Location = new System.Drawing.Point(304, 89);
            this.txtPes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPes.Name = "txtPes";
            this.txtPes.Size = new System.Drawing.Size(579, 24);
            this.txtPes.TabIndex = 1;
            // 
            // cbCat
            // 
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.Enabled = false;
            this.cbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(395, 123);
            this.cbCat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(299, 26);
            this.cbCat.TabIndex = 3;
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCat_SelectedIndexChanged_1);
            // 
            // cbPlat
            // 
            this.cbPlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlat.Enabled = false;
            this.cbPlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbPlat.FormattingEnabled = true;
            this.cbPlat.Location = new System.Drawing.Point(109, 123);
            this.cbPlat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPlat.Name = "cbPlat";
            this.cbPlat.Size = new System.Drawing.Size(183, 26);
            this.cbPlat.TabIndex = 2;
            this.cbPlat.SelectedIndexChanged += new System.EventHandler(this.cbPlat_SelectedIndexChanged);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Status",
            "Nome",
            "Valor",
            "Plataforma",
            "Categoria",
            "Código"});
            this.cbTipo.Location = new System.Drawing.Point(11, 87);
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
            this.gbStatus.Location = new System.Drawing.Point(533, 147);
            this.gbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStatus.Size = new System.Drawing.Size(161, 68);
            this.gbStatus.TabIndex = 5;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rdInat
            // 
            this.rdInat.AutoSize = true;
            this.rdInat.Location = new System.Drawing.Point(81, 29);
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
            this.rdAtiv.Location = new System.Drawing.Point(8, 29);
            this.rdAtiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdAtiv.Name = "rdAtiv";
            this.rdAtiv.Size = new System.Drawing.Size(65, 24);
            this.rdAtiv.TabIndex = 0;
            this.rdAtiv.Text = "Ativo";
            this.rdAtiv.UseVisualStyleBackColor = true;
            // 
            // gbVal
            // 
            this.gbVal.Controls.Add(this.txtVfi);
            this.gbVal.Controls.Add(this.txtVin);
            this.gbVal.Controls.Add(this.label3);
            this.gbVal.Controls.Add(this.label1);
            this.gbVal.Enabled = false;
            this.gbVal.Location = new System.Drawing.Point(7, 147);
            this.gbVal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbVal.Name = "gbVal";
            this.gbVal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbVal.Size = new System.Drawing.Size(518, 68);
            this.gbVal.TabIndex = 4;
            this.gbVal.TabStop = false;
            this.gbVal.Text = "Valores:";
            // 
            // txtVfi
            // 
            this.txtVfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtVfi.Location = new System.Drawing.Point(352, 29);
            this.txtVfi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVfi.Name = "txtVfi";
            this.txtVfi.Size = new System.Drawing.Size(158, 24);
            this.txtVfi.TabIndex = 1;
            // 
            // txtVin
            // 
            this.txtVin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtVin.Location = new System.Drawing.Point(102, 29);
            this.txtVin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(148, 24);
            this.txtVin.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor Inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tipo de pesquisa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gameplay", 26.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(171, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(542, 43);
            this.label7.TabIndex = 19;
            this.label7.Text = "Consulta de Produtos";
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
            this.button2.TabIndex = 31;
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
            this.button1.Location = new System.Drawing.Point(829, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // frmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(900, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgRes);
            this.Controls.Add(this.btPesq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPes);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.cbPlat);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbVal);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btEdit);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultaProduto";
            this.Text = "Consulta de Produtos";
            this.Load += new System.EventHandler(this.frmConsultaProduto_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastar);
            ((System.ComponentModel.ISupportInitialize)(this.dgRes)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbVal.ResumeLayout(false);
            this.gbVal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.DataGridView dgRes;
        private System.Windows.Forms.Button btPesq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPes;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.ComboBox cbPlat;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rdInat;
        private System.Windows.Forms.RadioButton rdAtiv;
        private System.Windows.Forms.GroupBox gbVal;
        private System.Windows.Forms.TextBox txtVfi;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}