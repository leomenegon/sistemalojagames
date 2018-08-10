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
    public partial class frmConsultaProduto : Form
    {
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btExitCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbStatus.Enabled = false;
            gbVal.Enabled = false;
            txtPes.Enabled = false;
            txtVfi.Enabled = false;
            txtVin.Enabled = false;
            cbCat.Enabled = false;
            cbPlat.Enabled = false;

            if (cbTipo.SelectedIndex == 0) gbStatus.Enabled = true;
            if (cbTipo.SelectedIndex == 1) txtPes.Enabled=true;
            if (cbTipo.SelectedIndex == 2) gbVal.Enabled = true; txtVfi.Enabled = true; txtVin.Enabled = true;
            if (cbTipo.SelectedIndex == 3)
            {
                cbPlat.Enabled = true;
                ClassPlataforma cPlat = new ClassPlataforma();
                cbPlat.DataSource = cPlat.SearchPlat();
                cbPlat.DisplayMember = "Plataforma";
                cbPlat.ValueMember = "CodPlat";
                cbPlat.SelectedIndex = -1;
            }
            if (cbTipo.SelectedIndex == 4)
            {
                cbCat.Enabled = true;
                ClassCategoria cc = new ClassCategoria();
                cbCat.DataSource = cc.CbCat();
                cbCat.DisplayMember = "Nome";
                cbCat.ValueMember = "CodCategoria";
                cbCat.SelectedIndex = -1;
            }
            if (cbTipo.SelectedIndex == 5) txtPes.Enabled = true;
        }

        private void btPesq_Click(object sender, EventArgs e)
        {
            ClassProduto cProd = new ClassProduto();

            if (cbTipo.SelectedIndex == -1) MessageBox.Show("Selecione um Tipo de pesquisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (cbTipo.SelectedIndex == 0 && rdAtiv.Checked == true) dgRes.DataSource = cProd.SearchProdStatus(); 
            if (cbTipo.SelectedIndex == 0 && rdAtiv.Checked == false) dgRes.DataSource = cProd.SearchProdStatusIna(); 
            if (cbTipo.SelectedIndex == 1 && txtPes.Text != "") { cProd.txtSearch = txtPes.Text; dgRes.DataSource = cProd.SearchProdNome(); }
            if (cbTipo.SelectedIndex == 3 && cbPlat.SelectedIndex != -1) { cProd.CodPlatS = Convert.ToInt32(cbPlat.SelectedValue); dgRes.DataSource = cProd.SearchProdPlat(); }
            if (cbTipo.SelectedIndex == 4 && cbCat.SelectedIndex != -1) { cProd.CatProdS = Convert.ToInt32(cbCat.SelectedValue); dgRes.DataSource = cProd.SearchProdCat(); }
            if(cbTipo.SelectedIndex==5 && txtPes.Text != "") dgRes.DataSource = cProd.SearchProdCod(Convert.ToInt32(txtPes.Text)); 



        }

        private void txtPes_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdInat_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgRes.SelectedCells.Count > 0)
            {
                ClassProduto cp = new ClassProduto();
                cp.ReturnProd(Convert.ToInt32(dgRes.SelectedRows[0].Cells[0].Value));
                frmCadastroProduto fp = new frmCadastroProduto();

                fp.txtNome.Text = cp.NomeProd.ToString();
                fp.txtDataCad.Text = cp.DataCadProd.ToString();
                fp.txtPreco.Text = cp.PrecoProd.ToString();
                fp.txtDescricao.Text = cp.DescProd.ToString();
                fp.txtQtde.Text = cp.QtdeProd.ToString();
                fp.txtCod.Text = cp.CodProd.ToString();
                fp.UpdatePlat = cp.CodPlat;
                fp.UpdateCat = cp.CatProd;

                fp.chkAtivo.Enabled = true;
                if (cp.StatusProd == 1) fp.chkAtivo.Checked = true;
                else fp.chkAtivo.Checked = false;

                fp.btCad.Visible = false;
                fp.btAtt.Visible = true;
                fp.ShowDialog();
                btPesq_Click(this, new EventArgs());
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dgRes.SelectedCells.Count > 0)
            {
                ClassProduto cp = new ClassProduto();
                cp.ReturnProd(Convert.ToInt32(dgRes.SelectedRows[0].Cells[0].Value));

                if (MessageBox.Show("Você Deseja Realmente Excluir o Produto'" + cp.NomeProd + "'?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    int aux = cp.DelProd();

                    if (aux != 0) MessageBox.Show("O Produto '" + cp.NomeProd + "' foi Excluido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else MessageBox.Show("Erro ao realizar Exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btPesq_Click(this, new EventArgs());
                }
            }
            }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbPlat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbCat_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void Arrastar(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
    }

