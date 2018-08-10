namespace SistemaLojaGames
{
    partial class frmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNomeSoc = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btCad = new System.Windows.Forms.Button();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.CbEst = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.dataCad = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.radFem = new System.Windows.Forms.RadioButton();
            this.radMasc = new System.Windows.Forms.RadioButton();
            this.btClear = new System.Windows.Forms.Button();
            this.BtAtt = new System.Windows.Forms.Button();
            this.CB_OREMISSOR = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNome.Location = new System.Drawing.Point(119, 150);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(511, 24);
            this.txtNome.TabIndex = 1;
            // 
            // txtNomeSoc
            // 
            this.txtNomeSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNomeSoc.Location = new System.Drawing.Point(119, 181);
            this.txtNomeSoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeSoc.MaxLength = 50;
            this.txtNomeSoc.Name = "txtNomeSoc";
            this.txtNomeSoc.Size = new System.Drawing.Size(511, 24);
            this.txtNomeSoc.TabIndex = 2;
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtEnd.Location = new System.Drawing.Point(119, 283);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnd.MaxLength = 50;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(511, 24);
            this.txtEnd.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCidade.Location = new System.Drawing.Point(119, 319);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCidade.MaxLength = 20;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(224, 24);
            this.txtCidade.TabIndex = 10;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCod.Location = new System.Drawing.Point(119, 116);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(126, 24);
            this.txtCod.TabIndex = 0;
            // 
            // btCad
            // 
            this.btCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCad.Location = new System.Drawing.Point(648, 357);
            this.btCad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCad.Name = "btCad";
            this.btCad.Size = new System.Drawing.Size(145, 61);
            this.btCad.TabIndex = 3;
            this.btCad.Text = "Cadastrar";
            this.btCad.UseVisualStyleBackColor = true;
            this.btCad.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtDataNasc.Location = new System.Drawing.Point(119, 215);
            this.txtDataNasc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(76, 24);
            this.txtDataNasc.TabIndex = 3;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // CbEst
            // 
            this.CbEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CbEst.FormattingEnabled = true;
            this.CbEst.Items.AddRange(new object[] {
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
            this.CbEst.Location = new System.Drawing.Point(412, 319);
            this.CbEst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbEst.Name = "CbEst";
            this.CbEst.Size = new System.Drawing.Size(85, 26);
            this.CbEst.TabIndex = 11;
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCep.Location = new System.Drawing.Point(554, 319);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(76, 24);
            this.txtCep.TabIndex = 12;
            // 
            // txtTel2
            // 
            this.txtTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtTel2.Location = new System.Drawing.Point(273, 215);
            this.txtTel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel2.Mask = "(00)00000-0000";
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(112, 24);
            this.txtTel2.TabIndex = 4;
            // 
            // txtTel1
            // 
            this.txtTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtTel1.Location = new System.Drawing.Point(518, 215);
            this.txtTel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel1.Mask = "(00)00000-0000";
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(112, 24);
            this.txtTel1.TabIndex = 5;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCpf.Location = new System.Drawing.Point(119, 249);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(113, 24);
            this.txtCpf.TabIndex = 6;
            // 
            // dataCad
            // 
            this.dataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dataCad.Location = new System.Drawing.Point(392, 116);
            this.dataCad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataCad.Name = "dataCad";
            this.dataCad.ReadOnly = true;
            this.dataCad.Size = new System.Drawing.Size(237, 24);
            this.dataCad.TabIndex = 11;
            this.dataCad.TextChanged += new System.EventHandler(this.dataCad_TextChanged);
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
            this.button2.Location = new System.Drawing.Point(775, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btMin
            // 
            this.btMin.BackColor = System.Drawing.Color.Transparent;
            this.btMin.BackgroundImage = global::SistemaLojaGames.Properties.Resources.pixel_icons2;
            this.btMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Location = new System.Drawing.Point(737, 1);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(32, 32);
            this.btMin.TabIndex = 13;
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(487, 251);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 20);
            this.label15.TabIndex = 41;
            this.label15.Text = "RG:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(350, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = "Estado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Cidade:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "CPF:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(506, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "CEP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Celular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tel. Residencial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(634, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Status:";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.chkAtivo.Location = new System.Drawing.Point(697, 118);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(66, 24);
            this.chkAtivo.TabIndex = 0;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Data de Nasc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Data de Cadastro:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nome Social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gameplay", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(123, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 43);
            this.label1.TabIndex = 42;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtRg.Location = new System.Drawing.Point(530, 249);
            this.txtRg.Mask = "00,000,000-00";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 24);
            this.txtRg.TabIndex = 8;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.radFem);
            this.gbSexo.Controls.Add(this.radMasc);
            this.gbSexo.Location = new System.Drawing.Point(638, 150);
            this.gbSexo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSexo.Size = new System.Drawing.Size(155, 69);
            this.gbSexo.TabIndex = 13;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // radFem
            // 
            this.radFem.AutoSize = true;
            this.radFem.Location = new System.Drawing.Point(10, 43);
            this.radFem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radFem.Name = "radFem";
            this.radFem.Size = new System.Drawing.Size(92, 24);
            this.radFem.TabIndex = 1;
            this.radFem.TabStop = true;
            this.radFem.Text = "Feminino";
            this.radFem.UseVisualStyleBackColor = true;
            // 
            // radMasc
            // 
            this.radMasc.AutoSize = true;
            this.radMasc.Location = new System.Drawing.Point(10, 20);
            this.radMasc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radMasc.Name = "radMasc";
            this.radMasc.Size = new System.Drawing.Size(98, 24);
            this.radMasc.TabIndex = 0;
            this.radMasc.TabStop = true;
            this.radMasc.Text = "Masculino";
            this.radMasc.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClear.Location = new System.Drawing.Point(523, 356);
            this.btClear.Margin = new System.Windows.Forms.Padding(4);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(117, 63);
            this.btClear.TabIndex = 14;
            this.btClear.Text = "Limpar";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClearCat_Click);
            // 
            // BtAtt
            // 
            this.BtAtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAtt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAtt.Location = new System.Drawing.Point(648, 356);
            this.BtAtt.Margin = new System.Windows.Forms.Padding(4);
            this.BtAtt.Name = "BtAtt";
            this.BtAtt.Size = new System.Drawing.Size(145, 63);
            this.BtAtt.TabIndex = 15;
            this.BtAtt.Text = "Atualizar";
            this.BtAtt.UseVisualStyleBackColor = true;
            this.BtAtt.Visible = false;
            this.BtAtt.Click += new System.EventHandler(this.BtAtt_Click);
            // 
            // CB_OREMISSOR
            // 
            this.CB_OREMISSOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_OREMISSOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CB_OREMISSOR.FormattingEnabled = true;
            this.CB_OREMISSOR.Location = new System.Drawing.Point(360, 249);
            this.CB_OREMISSOR.Name = "CB_OREMISSOR";
            this.CB_OREMISSOR.Size = new System.Drawing.Size(121, 26);
            this.CB_OREMISSOR.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(239, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 20);
            this.label16.TabIndex = 49;
            this.label16.Text = "Orgão Emissor:";
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 433);
            this.Controls.Add(this.CB_OREMISSOR);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.BtAtt);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataCad);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.CbEst);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.btCad);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtNomeSoc);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCadastroCliente_MouseDown);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtNomeSoc;
        public System.Windows.Forms.TextBox txtEnd;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.MaskedTextBox txtDataNasc;
        public System.Windows.Forms.ComboBox CbEst;
        public System.Windows.Forms.MaskedTextBox txtCep;
        public System.Windows.Forms.MaskedTextBox txtTel2;
        public System.Windows.Forms.MaskedTextBox txtTel1;
        public System.Windows.Forms.MaskedTextBox txtCpf;
        public System.Windows.Forms.TextBox dataCad;
        public System.Windows.Forms.MaskedTextBox txtRg;
        public System.Windows.Forms.RadioButton radFem;
        public System.Windows.Forms.RadioButton radMasc;
        public System.Windows.Forms.ComboBox CB_OREMISSOR;
        public System.Windows.Forms.Button btCad;
        public System.Windows.Forms.Button BtAtt;
        public System.Windows.Forms.Button btClear;
    }
}