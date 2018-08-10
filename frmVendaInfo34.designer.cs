namespace SistemaLojaGames
{
    partial class frmVendaInfo34
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendaInfo34));
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtPesqCliente = new System.Windows.Forms.TextBox();
            this.btBuscaCliente = new System.Windows.Forms.Button();
            this.btRemoveProduto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalDesconto = new System.Windows.Forms.TextBox();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.txtPesqProduto = new System.Windows.Forms.TextBox();
            this.btBuscaProduto = new System.Windows.Forms.Button();
            this.btFechaVenda = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAddProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFormaPagamento.Items.AddRange(new object[] {
            "Cartão de Débito",
            "Dinheiro"});
            this.cbFormaPagamento.Location = new System.Drawing.Point(721, 613);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(187, 32);
            this.cbFormaPagamento.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(611, 613);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 25);
            this.label12.TabIndex = 192;
            this.label12.Text = "Pagamento:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCliente);
            this.groupBox4.Controls.Add(this.txtPesqCliente);
            this.groupBox4.Controls.Add(this.btBuscaCliente);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(13, 150);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(529, 204);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente:";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.Location = new System.Drawing.Point(7, 70);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(514, 127);
            this.dgvCliente.TabIndex = 2;
            // 
            // txtPesqCliente
            // 
            this.txtPesqCliente.Location = new System.Drawing.Point(7, 31);
            this.txtPesqCliente.Name = "txtPesqCliente";
            this.txtPesqCliente.Size = new System.Drawing.Size(464, 32);
            this.txtPesqCliente.TabIndex = 0;
            // 
            // btBuscaCliente
            // 
            this.btBuscaCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscaCliente.BackgroundImage")));
            this.btBuscaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscaCliente.Location = new System.Drawing.Point(476, 22);
            this.btBuscaCliente.Name = "btBuscaCliente";
            this.btBuscaCliente.Size = new System.Drawing.Size(44, 42);
            this.btBuscaCliente.TabIndex = 1;
            this.btBuscaCliente.UseVisualStyleBackColor = true;
            this.btBuscaCliente.Click += new System.EventHandler(this.btBuscaCliente_Click);
            // 
            // btRemoveProduto
            // 
            this.btRemoveProduto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRemoveProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRemoveProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btRemoveProduto.Location = new System.Drawing.Point(5, 369);
            this.btRemoveProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btRemoveProduto.Name = "btRemoveProduto";
            this.btRemoveProduto.Size = new System.Drawing.Size(540, 48);
            this.btRemoveProduto.TabIndex = 0;
            this.btRemoveProduto.Text = "Remover";
            this.btRemoveProduto.UseVisualStyleBackColor = true;
            this.btRemoveProduto.Click += new System.EventHandler(this.btRemoveProduto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtObservacao);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(307, 606);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(297, 72);
            this.groupBox3.TabIndex = 190;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observações:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtObservacao.Location = new System.Drawing.Point(6, 19);
            this.txtObservacao.MaxLength = 150;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(284, 46);
            this.txtObservacao.TabIndex = 0;
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(721, 646);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(187, 36);
            this.txtTotalVenda.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(611, 649);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 188;
            this.label11.Text = "Total (R$):";
            // 
            // txtTotalDesconto
            // 
            this.txtTotalDesconto.Enabled = false;
            this.txtTotalDesconto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDesconto.Location = new System.Drawing.Point(197, 647);
            this.txtTotalDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalDesconto.Name = "txtTotalDesconto";
            this.txtTotalDesconto.Size = new System.Drawing.Size(103, 36);
            this.txtTotalDesconto.TabIndex = 186;
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDesconto.Location = new System.Drawing.Point(147, 647);
            this.txtValorDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorDesconto.MaxLength = 2;
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(42, 36);
            this.txtValorDesconto.TabIndex = 185;
            this.txtValorDesconto.TextChanged += new System.EventHandler(this.txtValorDesconto_TextChanged);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(147, 614);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(153, 36);
            this.txtValorTotal.TabIndex = 184;
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(615, 116);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(300, 32);
            this.txtProduto.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProduto);
            this.groupBox1.Controls.Add(this.txtPesqProduto);
            this.groupBox1.Controls.Add(this.btBuscaProduto);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 352);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(528, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto:";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProduto.Location = new System.Drawing.Point(8, 71);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(513, 176);
            this.dgvProduto.TabIndex = 2;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            this.dgvProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            this.dgvProduto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            this.dgvProduto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduto_CellContentClick);
            this.dgvProduto.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduto_CellContentClick);
            this.dgvProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProduto_CellContentClick);
            // 
            // txtPesqProduto
            // 
            this.txtPesqProduto.Location = new System.Drawing.Point(7, 31);
            this.txtPesqProduto.Name = "txtPesqProduto";
            this.txtPesqProduto.Size = new System.Drawing.Size(464, 32);
            this.txtPesqProduto.TabIndex = 0;
            // 
            // btBuscaProduto
            // 
            this.btBuscaProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscaProduto.BackgroundImage")));
            this.btBuscaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscaProduto.Location = new System.Drawing.Point(477, 21);
            this.btBuscaProduto.Name = "btBuscaProduto";
            this.btBuscaProduto.Size = new System.Drawing.Size(44, 42);
            this.btBuscaProduto.TabIndex = 1;
            this.btBuscaProduto.UseVisualStyleBackColor = true;
            this.btBuscaProduto.Click += new System.EventHandler(this.btBuscaProduto_Click);
            // 
            // btFechaVenda
            // 
            this.btFechaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechaVenda.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btFechaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFechaVenda.Location = new System.Drawing.Point(923, 613);
            this.btFechaVenda.Name = "btFechaVenda";
            this.btFechaVenda.Size = new System.Drawing.Size(176, 64);
            this.btFechaVenda.TabIndex = 11;
            this.btFechaVenda.Text = "Cadastrar Venda";
            this.btFechaVenda.UseVisualStyleBackColor = true;
            this.btFechaVenda.Click += new System.EventHandler(this.btFechaVenda_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(12, 650);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 25);
            this.label13.TabIndex = 177;
            this.label13.Text = "Desconto (%):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(12, 617);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 25);
            this.label10.TabIndex = 176;
            this.label10.Text = "Valor Bruto (R$):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvItens);
            this.groupBox2.Controls.Add(this.btRemoveProduto);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(549, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 422);
            this.groupBox2.TabIndex = 174;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carrinho:";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeColumns = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.Location = new System.Drawing.Point(5, 25);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(539, 339);
            this.dgvItens.TabIndex = 19;
            this.dgvItens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProduto_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(863, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 173;
            this.label7.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(914, 150);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(124, 32);
            this.txtTotal.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(667, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 171;
            this.label6.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(719, 151);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(138, 32);
            this.txtValor.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(547, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 169;
            this.label5.Text = "Qtde:";
            // 
            // txtQtde
            // 
            this.txtQtde.BackColor = System.Drawing.Color.White;
            this.txtQtde.Location = new System.Drawing.Point(615, 151);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(46, 32);
            this.txtQtde.TabIndex = 5;
            this.txtQtde.TextChanged += new System.EventHandler(this.txtQtde_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(546, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 166;
            this.label3.Text = "Produto:";
            // 
            // btAddProduto
            // 
            this.btAddProduto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btAddProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddProduto.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddProduto.Location = new System.Drawing.Point(1044, 116);
            this.btAddProduto.Name = "btAddProduto";
            this.btAddProduto.Size = new System.Drawing.Size(55, 62);
            this.btAddProduto.TabIndex = 8;
            this.btAddProduto.Text = "+";
            this.btAddProduto.UseVisualStyleBackColor = true;
            this.btAddProduto.Click += new System.EventHandler(this.btAddProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 164;
            this.label1.Text = "Funcionário:";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFuncionario.Location = new System.Drawing.Point(110, 116);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(432, 32);
            this.cbFuncionario.TabIndex = 0;
            // 
            // txtEstoque
            // 
            this.txtEstoque.BackColor = System.Drawing.Color.White;
            this.txtEstoque.Location = new System.Drawing.Point(992, 116);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(46, 32);
            this.txtEstoque.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(919, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 169;
            this.label4.Text = "Estoque:";
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
            this.button1.Location = new System.Drawing.Point(1040, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 194;
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
            this.button2.Location = new System.Drawing.Point(1078, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 195;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gameplay", 26.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(326, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(563, 53);
            this.label2.TabIndex = 196;
            this.label2.Text = "Cadastro de Venda";
            // 
            // frmVendaInfo34
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1111, 689);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbFormaPagamento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtTotalVenda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalDesconto);
            this.Controls.Add(this.txtValorDesconto);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btFechaVenda);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAddProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVendaInfo34";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frmVendaInfo34_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastar);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtPesqCliente;
        private System.Windows.Forms.Button btBuscaCliente;
        private System.Windows.Forms.Button btRemoveProduto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalDesconto;
        private System.Windows.Forms.TextBox txtValorDesconto;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtPesqProduto;
        private System.Windows.Forms.Button btBuscaProduto;
        private System.Windows.Forms.Button btFechaVenda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}