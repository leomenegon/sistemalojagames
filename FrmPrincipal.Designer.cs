namespace SistemaLojaGames
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuFeraramentas = new System.Windows.Forms.ToolStrip();
            this.btCadastro = new System.Windows.Forms.ToolStripSplitButton();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plataformaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btConsulta = new System.Windows.Forms.ToolStripSplitButton();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btVendas = new System.Windows.Forms.ToolStripSplitButton();
            this.cadastrarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btRelatorio = new System.Windows.Forms.ToolStripSplitButton();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.data = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuFeraramentas.SuspendLayout();
            this.barraStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFeraramentas
            // 
            this.menuFeraramentas.BackColor = System.Drawing.SystemColors.Window;
            this.menuFeraramentas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuFeraramentas.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuFeraramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCadastro,
            this.btConsulta,
            this.btVendas,
            this.btRelatorio,
            this.toolStripButton1});
            this.menuFeraramentas.Location = new System.Drawing.Point(0, 0);
            this.menuFeraramentas.MinimumSize = new System.Drawing.Size(284, 40);
            this.menuFeraramentas.Name = "menuFeraramentas";
            this.menuFeraramentas.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuFeraramentas.Size = new System.Drawing.Size(1264, 40);
            this.menuFeraramentas.TabIndex = 0;
            this.menuFeraramentas.Text = "menuFeraramentas";
            this.menuFeraramentas.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuFeraramentas_ItemClicked);
            // 
            // btCadastro
            // 
            this.btCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.plataformaToolStripMenuItem});
            this.btCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btCadastro.Image")));
            this.btCadastro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(102, 37);
            this.btCadastro.Text = "Cadastro";
            this.btCadastro.ButtonClick += new System.EventHandler(this.btCadastro_ButtonClick);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriaToolStripMenuItem.Image")));
            this.categoriaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem.Image")));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoToolStripMenuItem.Image")));
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionárioToolStripMenuItem.Image")));
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // plataformaToolStripMenuItem
            // 
            this.plataformaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("plataformaToolStripMenuItem.Image")));
            this.plataformaToolStripMenuItem.Name = "plataformaToolStripMenuItem";
            this.plataformaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.plataformaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.plataformaToolStripMenuItem.Text = "Plataforma";
            this.plataformaToolStripMenuItem.Click += new System.EventHandler(this.plataformaToolStripMenuItem_Click);
            // 
            // btConsulta
            // 
            this.btConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem1,
            this.clienteToolStripMenuItem1});
            this.btConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btConsulta.Image")));
            this.btConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(102, 37);
            this.btConsulta.Text = "Consulta";
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("produtoToolStripMenuItem1.Image")));
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem1.Image")));
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // btVendas
            // 
            this.btVendas.DropDownButtonWidth = 0;
            this.btVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarVendaToolStripMenuItem});
            this.btVendas.Image = ((System.Drawing.Image)(resources.GetObject("btVendas.Image")));
            this.btVendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btVendas.Name = "btVendas";
            this.btVendas.Size = new System.Drawing.Size(81, 37);
            this.btVendas.Text = "Vendas";
            this.btVendas.ButtonClick += new System.EventHandler(this.btVendas_ButtonClick);
            // 
            // cadastrarVendaToolStripMenuItem
            // 
            this.cadastrarVendaToolStripMenuItem.Name = "cadastrarVendaToolStripMenuItem";
            this.cadastrarVendaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.cadastrarVendaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cadastrarVendaToolStripMenuItem.Text = "Cadastrar Venda";
            this.cadastrarVendaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarVendaToolStripMenuItem_Click);
            // 
            // btRelatorio
            // 
            this.btRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem,
            this.clienteToolStripMenuItem2});
            this.btRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btRelatorio.Image")));
            this.btRelatorio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(102, 37);
            this.btRelatorio.Text = "Relatório";
            this.btRelatorio.ButtonClick += new System.EventHandler(this.btRelatorio_ButtonClick);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vendaToolStripMenuItem.Image")));
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem2
            // 
            this.clienteToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem2.Image")));
            this.clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            this.clienteToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.clienteToolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.clienteToolStripMenuItem2.Text = "Cliente";
            this.clienteToolStripMenuItem2.Click += new System.EventHandler(this.clienteToolStripMenuItem2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 37);
            this.toolStripButton1.Text = "Logoff";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // barraStatus
            // 
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.data});
            this.barraStatus.Location = new System.Drawing.Point(0, 659);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(1264, 22);
            this.barraStatus.SizingGrip = false;
            this.barraStatus.TabIndex = 1;
            this.barraStatus.Text = "Barra de Status";
            this.barraStatus.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.barraStatus_ItemClicked);
            // 
            // data
            // 
            this.data.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.data.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.data.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.data.Name = "data";
            this.data.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.data.Size = new System.Drawing.Size(0, 17);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.barraStatus);
            this.Controls.Add(this.menuFeraramentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frmPrincipal";
            this.Text = "Sistema Loja Games";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuFeraramentas.ResumeLayout(false);
            this.menuFeraramentas.PerformLayout();
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuFeraramentas;
        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.ToolStripStatusLabel data;
        private System.Windows.Forms.ToolStripSplitButton btCadastro;
        private System.Windows.Forms.ToolStripSplitButton btVendas;
        private System.Windows.Forms.ToolStripSplitButton btConsulta;
        private System.Windows.Forms.ToolStripSplitButton btRelatorio;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plataformaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarVendaToolStripMenuItem;
    }
}

