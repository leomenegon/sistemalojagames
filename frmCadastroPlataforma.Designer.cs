namespace SistemaLojaGames
{
    partial class frmCadastroPlataforma
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
            System.Windows.Forms.Button btCadPlat;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroPlataforma));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            btCadPlat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadPlat
            // 
            btCadPlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btCadPlat.Image = ((System.Drawing.Image)(resources.GetObject("btCadPlat.Image")));
            btCadPlat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btCadPlat.Location = new System.Drawing.Point(503, 116);
            btCadPlat.Name = "btCadPlat";
            btCadPlat.Size = new System.Drawing.Size(92, 51);
            btCadPlat.TabIndex = 1;
            btCadPlat.Text = "Cadastrar";
            btCadPlat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btCadPlat.UseVisualStyleBackColor = true;
            btCadPlat.Click += new System.EventHandler(this.btCadPlat_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 124);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(485, 27);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gameplay", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cadastro de Plataforma";
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
            this.button2.Location = new System.Drawing.Point(574, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmCadastroPlataforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(607, 179);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(btCadPlat);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroPlataforma";
            this.Text = "Cadastrar Plataforma";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastar);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}