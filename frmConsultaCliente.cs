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
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbStatus.Enabled = false;
            cbEst.Enabled = false;
            txtCod.Enabled = false;
            mskCpf.Enabled = false;
            txtPes.Enabled = false;
            txtPes.Clear();
            mskCpf.Clear();
            txtCod.Clear();
            cbEst.SelectedIndex = -1;
            rdAtiv.Checked = false;
            rdInat.Checked = false;           

            if (cbTipo.SelectedIndex == 0) gbStatus.Enabled = true;
            if (cbTipo.SelectedIndex == 1) txtPes.Enabled = true;
            if (cbTipo.SelectedIndex == 2) cbEst.Enabled = true;
            if (cbTipo.SelectedIndex == 3) mskCpf.Enabled = true;
            if (cbTipo.SelectedIndex == 4) txtCod.Enabled = true;
        }

        private void btPesq_Click(object sender, EventArgs e)
        {
            ClassCliente cc = new ClassCliente();


            if (cbTipo.SelectedIndex == -1) MessageBox.Show("Selecione um Tipo de pesquisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (cbTipo.SelectedIndex == 0 && rdAtiv.Checked == true) { dgRes.DataSource = cc.SearchClieStatusAtiv(); }
            if (cbTipo.SelectedIndex == 0 && rdAtiv.Checked == false) { dgRes.DataSource = cc.SearchClieStatusInat(); }
            if (cbTipo.SelectedIndex == 1 && txtPes.Text != "") { cc.txtSearch = txtPes.Text; dgRes.DataSource = cc.SearchClieNome(); }
            if (cbTipo.SelectedIndex == 2 && cbEst.SelectedIndex != -1) { cc.EndEstadoClienteS =Convert.ToString(cbEst.SelectedItem); dgRes.DataSource = cc.SearchClieEst(); }
            if (cbTipo.SelectedIndex == 3 && mskCpf.Text != "   ,   ,   -") { cc.CpfClienteS = mskCpf.Text; dgRes.DataSource = cc.SearchClieCpf(); }
            if (cbTipo.SelectedIndex == 4 && txtCod.Text != "") { cc.CodClienteS = Convert.ToInt32(txtCod.Text); dgRes.DataSource = cc.SearchClieCod(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgRes.SelectedCells.Count > 0)
            {
                ClassCliente cc = new ClassCliente();
                cc.RetornClie(Convert.ToInt32(dgRes.SelectedRows[0].Cells[0].Value));
                frmCadastroCliente fc = new frmCadastroCliente();

                fc.txtCod.Text = cc.CodCliente.ToString();
                fc.dataCad.Text = cc.DataCadCliente.ToString();
                fc.txtNome.Text = cc.NomeCliente;
                fc.txtNomeSoc.Text = cc.NomeSocCliente;
                fc.txtDataNasc.Text = cc.DataNascClie.ToString("dd-MM-yyyy");
                fc.txtTel1.Text = cc.TelCliente1;
                fc.txtTel2.Text = cc.TelCliente2;
                fc.txtCpf.Text = cc.CpfCliente;
                fc.CB_OREMISSOR.Text = cc.OrgEmiClie;
                fc.txtRg.Text = cc.RgClie;
                fc.txtEnd.Text = cc.EndRuaCliente;
                fc.txtCidade.Text = cc.EndCityCliente;
                fc.CbEst.Text = cc.EndEstadoCliente;
                fc.txtCep.Text = cc.EndCepCliente;

                fc.chkAtivo.Enabled = true;
                if (cc.StatusClieI == 1) fc.chkAtivo.Checked = true;
                else fc.chkAtivo.Checked = false;

                if (cc.SexoCliente == 1) fc.radFem.Checked = true;
                else fc.radMasc.Checked = true;

                fc.btCad.Visible = false;
                fc.BtAtt.Visible = true;
                fc.btClear.Visible = false;
                fc.ShowDialog();
                btPesq_Click(this, new EventArgs());
            }
        }

        private void btRpt_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(dgRes.SelectedRows[0].Cells[0].Value);
            GlobalVar.VarGlobal = cod;
            this.Close();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btDel_Click(object sender, EventArgs e)
        {          
            if (dgRes.SelectedCells.Count > 0)
            {
                ClassCliente cc = new ClassCliente();
                cc.RetornClie(Convert.ToInt32(dgRes.SelectedRows[0].Cells[0].Value));

                if (MessageBox.Show("Você Deseja Realmente Excluir o Cliente '" + cc.NomeCliente + "' ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    int aux = cc.DelClie();

                    if (aux != 0) MessageBox.Show("O Cliente '" + cc.NomeCliente + "' foi Excluido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else MessageBox.Show("Erro ao realizar Exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btPesq_Click(this, new EventArgs());
                }
            }
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
