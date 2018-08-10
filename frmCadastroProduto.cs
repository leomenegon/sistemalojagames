using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLojaGames
{
    public partial class frmCadastroProduto : Form
    {
        public int UpdatePlat = -1;
        public int UpdateCat = -1;

        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            ClassPlataforma cPlat = new ClassPlataforma();
            CbPlat.DataSource = cPlat.SearchPlat();
            CbPlat.DisplayMember = "Plataforma";
            CbPlat.ValueMember = "CodPlat";
            CbPlat.SelectedValue = UpdatePlat;

            ClassCategoria CCat = new ClassCategoria();
            CbCat.DataSource = CCat.CbCat();
            CbCat.DisplayMember = "Nome";
            CbCat.ValueMember = "CodCategoria";
            CbCat.SelectedValue = UpdateCat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtQtde.Text != "" && CbPlat.TabIndex != 1 && CbCat.SelectedIndex != -1)
            {
                ClassConexao cCon = new ClassConexao();
                ClassProduto cProd = new ClassProduto();

                decimal Preco;
                int Qtde = Convert.ToInt32(txtQtde.Text);

                if (txtPreco.Text != "") Preco = Convert.ToDecimal(txtPreco.Text);
                else Preco = 0;                

                cProd.NomeProd = txtNome.Text;
                cProd.PrecoProd = Preco;
                cProd.DescProd = txtDescricao.Text;
                cProd.QtdeProd = Qtde;
                cProd.StatusProd = 1;
                cProd.CodPlat = Convert.ToInt32(CbPlat.SelectedValue);
                cProd.CatProd = Convert.ToInt32(CbCat.SelectedValue);

                int aux = cProd.CadastrarProduto();

                if (aux != 0) MessageBox.Show("O Produto '" + cProd.NomeProd + "' foi cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else MessageBox.Show("Erro ao Realizar Cadastro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Verificar Campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.BackColor = Color.DarkRed;
                txtQtde.BackColor = Color.DarkRed;
                txtPreco.BackColor = Color.DarkRed;                
            }
        }

        private void cbPlat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAtt_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtQtde.Text != "" && CbPlat.TabIndex != -1)
            {
                ClassConexao cCon = new ClassConexao();
                ClassProduto cProd = new ClassProduto();

                decimal Preco;
                int Qtde = Convert.ToInt32(txtQtde.Text);

                if (txtPreco.Text != "") Preco = Convert.ToDecimal(txtPreco.Text);
                else Preco = 0;


                if (chkAtivo.Checked == false) cProd.StatusProd = 0;
                else cProd.StatusProd = 1;

                cProd.CodProd = Convert.ToInt32(txtCod.Text);
                cProd.NomeProd = txtNome.Text;
                cProd.PrecoProd = Preco;
                cProd.DescProd = txtDescricao.Text;
                cProd.QtdeProd = Qtde;
                cProd.CodPlat = Convert.ToInt32(CbPlat.SelectedValue);
                cProd.CatProd = Convert.ToInt32(CbCat.SelectedValue);

                int aux = cProd.AttProd();

                if (aux != 0)
                {
                    MessageBox.Show("O produto '" + cProd.NomeProd + "' foi Atualizado com Sucesso!");
                    this.Close();
                }

                else MessageBox.Show("Erro ao Realizar Atualização!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Verificar Campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;


        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_LBUTTONDOWN)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void frmCadastroProduto_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtPreco.Clear();
            txtQtde.Clear();
            txtDescricao.Clear();
            CbCat.SelectedIndex = -1;
            CbPlat.SelectedIndex = -1;
        }
    }
}
