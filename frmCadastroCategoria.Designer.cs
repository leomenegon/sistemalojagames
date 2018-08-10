namespace SistemaLojaGames
{
    partial class frmCadastroCategoria
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
            System.Windows.Forms.Button btCadCat;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCategoria));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescCat = new System.Windows.Forms.TextBox();
            this.txtNomeCat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.boxStatusCat = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.dataCad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btClearCat = new System.Windows.Forms.Button();
            btCadCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadCat
            // 
            btCadCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btCadCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btCadCat.Location = new System.Drawing.Point(535, 492);
            btCadCat.Margin = new System.Windows.Forms.Padding(4);
            btCadCat.Name = "btCadCat";
            btCadCat.Size = new System.Drawing.Size(138, 61);
            btCadCat.TabIndex = 3;
            btCadCat.Text = "Cadastrar";
            btCadCat.UseVisualStyleBackColor = true;
            btCadCat.Click += new System.EventHandler(this.btCadCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // txtDescCat
            // 
            this.txtDescCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescCat.Location = new System.Drawing.Point(18, 197);
            this.txtDescCat.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescCat.MaxLength = 500;
            this.txtDescCat.Multiline = true;
            this.txtDescCat.Name = "txtDescCat";
            this.txtDescCat.Size = new System.Drawing.Size(655, 285);
            this.txtDescCat.TabIndex = 1;
            // 
            // txtNomeCat
            // 
            this.txtNomeCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNomeCat.Location = new System.Drawing.Point(81, 136);
            this.txtNomeCat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCat.MaxLength = 20;
            this.txtNomeCat.Name = "txtNomeCat";
            this.txtNomeCat.Size = new System.Drawing.Size(592, 24);
            this.txtNomeCat.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gameplay", 26.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(53, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(553, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cadastro de Categoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(217, 101);
            this.lbData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(46, 20);
            this.lbData.TabIndex = 2;
            this.lbData.Text = "Data:";
            // 
            // boxStatusCat
            // 
            this.boxStatusCat.AutoSize = true;
            this.boxStatusCat.Checked = true;
            this.boxStatusCat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boxStatusCat.Enabled = false;
            this.boxStatusCat.Location = new System.Drawing.Point(612, 102);
            this.boxStatusCat.Margin = new System.Windows.Forms.Padding(4);
            this.boxStatusCat.Name = "boxStatusCat";
            this.boxStatusCat.Size = new System.Drawing.Size(66, 24);
            this.boxStatusCat.TabIndex = 1;
            this.boxStatusCat.Text = "Ativo";
            this.boxStatusCat.UseVisualStyleBackColor = true;
            this.boxStatusCat.CheckedChanged += new System.EventHandler(this.boxStatusCat_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código:";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCod.Location = new System.Drawing.Point(81, 99);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4);
            this.txtCod.MaxLength = 20;
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(128, 24);
            this.txtCod.TabIndex = 0;
            // 
            // dataCad
            // 
            this.dataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dataCad.Location = new System.Drawing.Point(271, 99);
            this.dataCad.Margin = new System.Windows.Forms.Padding(4);
            this.dataCad.MaxLength = 20;
            this.dataCad.Name = "dataCad";
            this.dataCad.ReadOnly = true;
            this.dataCad.Size = new System.Drawing.Size(270, 24);
            this.dataCad.TabIndex = 8;
            this.dataCad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataCad_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(548, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status:";
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
            this.button1.Location = new System.Drawing.Point(621, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button2.Location = new System.Drawing.Point(659, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btClearCat
            // 
            this.btClearCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClearCat.Location = new System.Drawing.Point(410, 492);
            this.btClearCat.Margin = new System.Windows.Forms.Padding(4);
            this.btClearCat.Name = "btClearCat";
            this.btClearCat.Size = new System.Drawing.Size(117, 61);
            this.btClearCat.TabIndex = 2;
            this.btClearCat.Text = "Limpar";
            this.btClearCat.UseVisualStyleBackColor = true;
            this.btClearCat.Click += new System.EventHandler(this.btClearCat_Click);
            // 
            // frmCadastroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(692, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxStatusCat);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.dataCad);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(btCadCat);
            this.Controls.Add(this.btClearCat);
            this.Controls.Add(this.txtNomeCat);
            this.Controls.Add(this.txtDescCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastroCategoria";
            this.Text = "Cadastrar Categoria";
            this.Load += new System.EventHandler(this.frmCadastroCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescCat;
        private System.Windows.Forms.TextBox txtNomeCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.CheckBox boxStatusCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox dataCad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btClearCat;
    }
}