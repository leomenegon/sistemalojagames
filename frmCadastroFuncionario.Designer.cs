namespace SistemaLojaGames
{
    partial class frmCadastroFuncionario
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNomeSoc = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.radFem = new System.Windows.Forms.RadioButton();
            this.radMasc = new System.Windows.Forms.RadioButton();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.cbEst = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtDataCad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btClearCat = new System.Windows.Forms.Button();
            this.btAttCat = new System.Windows.Forms.Button();
            this.CB_OREMISSOR = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.gbSexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNome.Location = new System.Drawing.Point(119, 137);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(508, 24);
            this.txtNome.TabIndex = 1;
            // 
            // txtNomeSoc
            // 
            this.txtNomeSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNomeSoc.Location = new System.Drawing.Point(119, 170);
            this.txtNomeSoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeSoc.Name = "txtNomeSoc";
            this.txtNomeSoc.Size = new System.Drawing.Size(508, 24);
            this.txtNomeSoc.TabIndex = 2;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCpf.Location = new System.Drawing.Point(119, 238);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(112, 24);
            this.txtCpf.TabIndex = 6;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.radFem);
            this.gbSexo.Controls.Add(this.radMasc);
            this.gbSexo.Location = new System.Drawing.Point(637, 137);
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
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtUser.Location = new System.Drawing.Point(10, 41);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(133, 24);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPass.Location = new System.Drawing.Point(10, 88);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(133, 24);
            this.txtPass.TabIndex = 1;
            // 
            // txtTel2
            // 
            this.txtTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtTel2.Location = new System.Drawing.Point(518, 204);
            this.txtTel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel2.Mask = "(00)00000-0000";
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(109, 24);
            this.txtTel2.TabIndex = 5;
            this.txtTel2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTel3_MaskInputRejected);
            // 
            // txtTel1
            // 
            this.txtTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtTel1.Location = new System.Drawing.Point(276, 204);
            this.txtTel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel1.Mask = "(00)00000-0000";
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(109, 24);
            this.txtTel1.TabIndex = 4;
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtRua.Location = new System.Drawing.Point(119, 272);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(508, 24);
            this.txtRua.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCity.Location = new System.Drawing.Point(119, 308);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(224, 24);
            this.txtCity.TabIndex = 10;
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCep.Location = new System.Drawing.Point(552, 308);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(75, 24);
            this.txtCep.TabIndex = 12;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtDataNasc.Location = new System.Drawing.Point(119, 204);
            this.txtDataNasc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(81, 24);
            this.txtDataNasc.TabIndex = 3;
            // 
            // btCadastrar
            // 
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Location = new System.Drawing.Point(663, 347);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(129, 61);
            this.btCadastrar.TabIndex = 11;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbEst
            // 
            this.cbEst.BackColor = System.Drawing.SystemColors.Window;
            this.cbEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbEst.Location = new System.Drawing.Point(417, 308);
            this.cbEst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEst.Name = "cbEst";
            this.cbEst.Size = new System.Drawing.Size(80, 26);
            this.cbEst.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gameplay", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(72, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastro de Funcionarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data de Cadastro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Código:";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCod.Location = new System.Drawing.Point(119, 104);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(137, 24);
            this.txtCod.TabIndex = 16;
            // 
            // txtDataCad
            // 
            this.txtDataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtDataCad.ForeColor = System.Drawing.Color.Yellow;
            this.txtDataCad.Location = new System.Drawing.Point(401, 104);
            this.txtDataCad.Name = "txtDataCad";
            this.txtDataCad.ReadOnly = true;
            this.txtDataCad.Size = new System.Drawing.Size(226, 24);
            this.txtDataCad.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(633, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Status:";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.chkAtivo.Location = new System.Drawing.Point(696, 105);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(66, 24);
            this.chkAtivo.TabIndex = 0;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.chkAtivo_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nome Social:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data de Nasc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tel. Residencial:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Celular:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Endereço:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(504, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "CEP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cidade:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(350, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Estado:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "CPF:";
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtRg.Location = new System.Drawing.Point(527, 238);
            this.txtRg.Mask = "00,000,000-00";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 24);
            this.txtRg.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(487, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "RG:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Location = new System.Drawing.Point(637, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 122);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Senha:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Usuário:";
            // 
            // btClearCat
            // 
            this.btClearCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClearCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClearCat.Location = new System.Drawing.Point(538, 347);
            this.btClearCat.Margin = new System.Windows.Forms.Padding(4);
            this.btClearCat.Name = "btClearCat";
            this.btClearCat.Size = new System.Drawing.Size(117, 61);
            this.btClearCat.TabIndex = 15;
            this.btClearCat.Text = "Limpar";
            this.btClearCat.UseVisualStyleBackColor = true;
            this.btClearCat.Click += new System.EventHandler(this.btClearCat_Click);
            // 
            // btAttCat
            // 
            this.btAttCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAttCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAttCat.Location = new System.Drawing.Point(663, 347);
            this.btAttCat.Margin = new System.Windows.Forms.Padding(4);
            this.btAttCat.Name = "btAttCat";
            this.btAttCat.Size = new System.Drawing.Size(129, 61);
            this.btAttCat.TabIndex = 16;
            this.btAttCat.Text = "Atualizar";
            this.btAttCat.UseVisualStyleBackColor = true;
            this.btAttCat.Visible = false;
            // 
            // CB_OREMISSOR
            // 
            this.CB_OREMISSOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_OREMISSOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CB_OREMISSOR.FormattingEnabled = true;
            this.CB_OREMISSOR.Location = new System.Drawing.Point(360, 238);
            this.CB_OREMISSOR.Name = "CB_OREMISSOR";
            this.CB_OREMISSOR.Size = new System.Drawing.Size(121, 26);
            this.CB_OREMISSOR.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(239, 240);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 20);
            this.label18.TabIndex = 51;
            this.label18.Text = "Orgão Emissor:";
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
            this.button1.Location = new System.Drawing.Point(734, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 28;
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
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(772, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Gameplay", 26.25F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(561, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 43);
            this.label19.TabIndex = 14;
            this.label19.Text = "\'";
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(805, 420);
            this.Controls.Add(this.CB_OREMISSOR);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btClearCat);
            this.Controls.Add(this.btAttCat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtRg);
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
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtDataCad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEst);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNomeSoc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label19);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadastroFuncionario";
            this.RightToLeftLayout = true;
            this.Text = "Cadastrar Funcionário";
            this.Load += new System.EventHandler(this.frmCadastroFuncionario_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCadastroFuncionario_MouseDown);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNomeSoc;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton radFem;
        private System.Windows.Forms.RadioButton radMasc;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.MaskedTextBox txtTel2;
        private System.Windows.Forms.MaskedTextBox txtTel1;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.ComboBox cbEst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.TextBox txtDataCad;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btClearCat;
        private System.Windows.Forms.Button btAttCat;
        private System.Windows.Forms.ComboBox CB_OREMISSOR;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}