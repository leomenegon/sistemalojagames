namespace SistemaLojaGames
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.btCad = new System.Windows.Forms.Button();
            this.txtDataCad = new System.Windows.Forms.TextBox();
            this.CbPlat = new System.Windows.Forms.ComboBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btAtt = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbCat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNome.Location = new System.Drawing.Point(93, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(521, 24);
            this.txtNome.TabIndex = 1;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPreco.Location = new System.Drawing.Point(64, 22);
            this.txtPreco.MaxLength = 5;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(103, 24);
            this.txtPreco.TabIndex = 0;
            // 
            // txtQtde
            // 
            this.txtQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtQtde.Location = new System.Drawing.Point(457, 22);
            this.txtQtde.MaxLength = 11;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(130, 24);
            this.txtQtde.TabIndex = 1;
            // 
            // btCad
            // 
            this.btCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btCad.Location = new System.Drawing.Point(530, 518);
            this.btCad.Name = "btCad";
            this.btCad.Size = new System.Drawing.Size(111, 61);
            this.btCad.TabIndex = 3;
            this.btCad.Text = "Cadastrar";
            this.btCad.UseVisualStyleBackColor = true;
            this.btCad.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDataCad
            // 
            this.txtDataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtDataCad.ForeColor = System.Drawing.Color.Yellow;
            this.txtDataCad.Location = new System.Drawing.Point(293, 24);
            this.txtDataCad.Name = "txtDataCad";
            this.txtDataCad.ReadOnly = true;
            this.txtDataCad.Size = new System.Drawing.Size(183, 24);
            this.txtDataCad.TabIndex = 7;
            // 
            // CbPlat
            // 
            this.CbPlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CbPlat.FormattingEnabled = true;
            this.CbPlat.Location = new System.Drawing.Point(446, 86);
            this.CbPlat.Name = "CbPlat";
            this.CbPlat.Size = new System.Drawing.Size(168, 26);
            this.CbPlat.TabIndex = 3;
            this.CbPlat.SelectedIndexChanged += new System.EventHandler(this.cbPlat_SelectedIndexChanged);
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCod.Location = new System.Drawing.Point(93, 23);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(55, 24);
            this.txtCod.TabIndex = 9;
            // 
            // btAtt
            // 
            this.btAtt.Enabled = false;
            this.btAtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btAtt.Location = new System.Drawing.Point(530, 518);
            this.btAtt.Name = "btAtt";
            this.btAtt.Size = new System.Drawing.Size(111, 61);
            this.btAtt.TabIndex = 2;
            this.btAtt.Text = "Atualizar";
            this.btAtt.UseVisualStyleBackColor = true;
            this.btAtt.Visible = false;
            this.btAtt.Click += new System.EventHandler(this.btAtt_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.chkAtivo.Location = new System.Drawing.Point(545, 25);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(66, 24);
            this.chkAtivo.TabIndex = 0;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.chkAtivo_CheckedChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtDescricao.Location = new System.Drawing.Point(11, 174);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(605, 228);
            this.txtDescricao.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Gameplay", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CbCat);
            this.panel1.Controls.Add(this.CbPlat);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCod);
            this.panel1.Controls.Add(this.txtDataCad);
            this.panel1.Controls.Add(this.chkAtivo);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 425);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtQtde);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(11, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Preço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(357, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data de Cadastro:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CbCat
            // 
            this.CbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CbCat.FormattingEnabled = true;
            this.CbCat.Location = new System.Drawing.Point(93, 86);
            this.CbCat.Name = "CbCat";
            this.CbCat.Size = new System.Drawing.Size(250, 26);
            this.CbCat.TabIndex = 2;
            this.CbCat.SelectedIndexChanged += new System.EventHandler(this.cbPlat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Plataforma:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Categoria:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(7, 55);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(56, 20);
            this.lbNome.TabIndex = 14;
            this.lbNome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(482, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Status:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SistemaLojaGames.Properties.Resources.pixel_icons2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(588, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::SistemaLojaGames.Properties.Resources.pixel_icons;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(623, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(413, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 61);
            this.button3.TabIndex = 1;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(656, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btAtt);
            this.Controls.Add(this.btCad);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroProduto";
            this.Text = "Cadastro Produto";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCadastroProduto_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtPreco;
        public System.Windows.Forms.TextBox txtQtde;
        public System.Windows.Forms.TextBox txtDataCad;
        public System.Windows.Forms.ComboBox CbPlat;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.CheckBox chkAtivo;
        public System.Windows.Forms.Button btCad;
        public System.Windows.Forms.Button btAtt;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox CbCat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
    }
}