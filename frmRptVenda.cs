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
    public partial class frmRptVenda : Form
    {
        public frmRptVenda()
        {
            InitializeComponent();
        }

        private void frmRptVenda_Load(object sender, EventArgs e)
        {
            ClassFuncionario c = new ClassFuncionario();
            cbFuncionario.DataSource = c.SearchFuncV();
            cbFuncionario.DisplayMember = "Nome";
            cbFuncionario.ValueMember = "CodFuncionario";
            cbFuncionario.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btPesqClie_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.btDel.Visible = false;
            f.btEdit.Visible = false;
            f.btRpt.Visible = true;
            f.ShowDialog();
            txtCodC.Text = GlobalVar.VarGlobal.ToString();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            ClassRelatorioV cv = new ClassRelatorioV();

            if (cbTipo.SelectedIndex == 0 && txtCodC.Text != "")
            {
                int cod = Convert.ToInt32(txtCodC.Text);

                ClassRelatorioVBindingSource.DataSource = cv.RptCod(cod);
            }
            if (cbTipo.SelectedItem.ToString() == "Venda" && txtCodV.Text != "")
            {
                int cod = Convert.ToInt32(txtCodV.Text);

                ClassRelatorioVBindingSource.DataSource = cv.RptCodV(cod);
            }
            if (cbTipo.SelectedIndex == 2)
            {
                DateTime dataI, DataF;
                dataI = Convert.ToDateTime(DtInicial.Value);
                DataF = Convert.ToDateTime(DtFinal.Value);

                ClassRelatorioVBindingSource.DataSource = cv.RptDataBet(dataI, DataF);
            }
            if (cbTipo.SelectedIndex == 4&&cbFuncionario.SelectedIndex!=-1)
            {
                DateTime dataI, DataF;
                dataI = Convert.ToDateTime(DtInicial.Value);
                DataF = Convert.ToDateTime(DtFinal.Value);
                int cod = Convert.ToInt32(cbFuncionario.SelectedValue);

                ClassRelatorioVBindingSource.DataSource = cv.RptDataBetFunc(dataI, DataF,cod);
            }
            if (cbTipo.SelectedIndex == 3&&cbFuncionario.SelectedIndex!=-1)
            {
                int cod = Convert.ToInt32(cbFuncionario.SelectedValue);
                ClassRelatorioVBindingSource.DataSource = cv.RptCodF(cod);
            }
            if (cbTipo.SelectedIndex == 5 && txtCodC.Text != "")
            {
                DateTime dataI, DataF;
                int cod = Convert.ToInt32(txtCodC.Text);
                dataI = Convert.ToDateTime(DtInicial.Value);
                DataF = Convert.ToDateTime(DtFinal.Value);

                ClassRelatorioVBindingSource.DataSource = cv.RptDataBetClie(dataI, DataF, cod);
            }
            cv.Obs = cbTipo.SelectedItem.ToString();
            this.reportViewer1.RefreshReport();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DtFinal.Enabled = false;
            DtInicial.Enabled = false;
            cbFuncionario.Enabled = false;
            txtCodC.Enabled = false;
            btPesqClie.Enabled = false;
            txtCodV.Enabled = false;

            if (cbTipo.SelectedIndex == 0)
            {
                txtCodC.Enabled = true;
                btPesqClie.Enabled = true;
            }
            if (cbTipo.SelectedIndex == 1)
            {
                txtCodV.Enabled = true;
            }
            if (cbTipo.SelectedIndex == 2)
            {
                DtFinal.Enabled = true;
                DtInicial.Enabled = true;
            }
            if (cbTipo.SelectedIndex == 4)
            {
                DtFinal.Enabled = true;
                DtInicial.Enabled = true;
                cbFuncionario.Enabled = true;
            }
            if (cbTipo.SelectedIndex == 3)
            {
                cbFuncionario.Enabled = true;
            }
            if (cbTipo.SelectedIndex == 5)
            {
                DtFinal.Enabled = true;
                DtInicial.Enabled = true;
                txtCodC.Enabled = true;
                btPesqClie.Enabled = true;
            }


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
