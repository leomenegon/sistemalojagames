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
    public partial class frmGerarRelatorio : Form
    {
        public frmGerarRelatorio()
        {
            InitializeComponent();
        }

        private void TrocarTipo()
        {
            lbMes.Visible = false;
            cbMes.Visible = false;
            lbDia.Visible = false;
            mskDia.Visible = false;
            mskAno.Visible = false;
            lbAno.Visible = false;
            lbIdin.Visible = false;
            lbIdfin.Visible = false;
            TxtIdfin.Visible = false;
            TxtIdin.Visible = false;
            LbCidade.Visible = false;
            CbCidade.Visible = false;
            lbSexo.Visible = false;
            RdFem.Visible = false;
            RdMasc.Visible = false;
            lbStatus.Visible = false;
            RdAtiv.Visible = false;
            RdInat.Visible = false;
        }
        private void brGerar_Click(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex == -1) MessageBox.Show("Selecione um tipo de Relatório para Gerar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (cbTipo.SelectedIndex == 0 && cbMes.SelectedIndex != -1 && mskDia.Text != "")
                {
                    ClassCliente c = new ClassCliente();

                    int mes = cbMes.SelectedIndex + 1;
                    int dia = Convert.ToInt32(mskDia.Text);

                    ClassClienteBindingSource.DataSource = c.RelatorioClienteDIAMES(mes, dia);
                    this.reportViewer1.RefreshReport();
                }
                //else MessageBox.Show("Verificar Campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (cbTipo.SelectedIndex == 1 && cbMes.SelectedIndex != -1)
                {

                    ClassCliente c = new ClassCliente();

                    int mes = cbMes.SelectedIndex + 1;

                    ClassClienteBindingSource.DataSource = c.RelatorioClienteMES(mes);
                    this.reportViewer1.RefreshReport();
                }
                //else MessageBox.Show("Verificar Campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (cbTipo.SelectedIndex == 2 && cbMes.SelectedIndex != -1 && mskDia.Text != "" && mskAno.Text != "  /  /")
                {
                    ClassCliente c = new ClassCliente();

                    int mes = cbMes.SelectedIndex + 1;
                    int dia = Convert.ToInt32(mskDia.Text);
                    int ano = Convert.ToInt32(mskAno.Text);

                    ClassClienteBindingSource.DataSource = c.RelatorioClienteDATA(dia, mes, ano);
                    this.reportViewer1.RefreshReport();
                }
                //else MessageBox.Show("Verificar Campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (cbTipo.SelectedIndex == 3 && TxtIdin.Text != "" && TxtIdfin.Text != "")
                {
                    int idadeI, IdadeF;
                    idadeI = Convert.ToInt32(TxtIdin.Text);
                    IdadeF = Convert.ToInt32(TxtIdfin.Text);

                    ClassCliente c = new ClassCliente();
                    ClassClienteBindingSource.DataSource = c.RelatorioClienteIDADE(idadeI, IdadeF);
                    this.reportViewer1.RefreshReport();
                }
                //else MessageBox.Show("Verificar Campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (cbTipo.SelectedIndex == 4 && TxtIdin.Text != "")
                {
                    int idadeI = Convert.ToInt32(TxtIdin.Text);

                    ClassCliente c = new ClassCliente();
                    ClassClienteBindingSource.DataSource = c.RelatorioClienteMAIORDE(idadeI);
                    this.reportViewer1.RefreshReport();
                }
                //else MessageBox.Show("Verificar Campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (cbTipo.SelectedIndex == 5 && CbCidade.SelectedIndex != -1)
                {
                    string cidade = CbCidade.Text;

                    ClassCliente c = new ClassCliente();
                    ClassClienteBindingSource.DataSource = c.RelatorioClienteCIDADE(cidade);
                    this.reportViewer1.RefreshReport();
                }
                //else MessageBox.Show("Verificar Campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (cbTipo.SelectedIndex == 6)
                {
                    if (RdMasc.Checked == true || RdFem.Checked == true)
                    {
                        int s = 0;
                        if (RdMasc.Checked == true) s = 0;
                        if (RdFem.Checked == true) s = 1;

                        ClassCliente c = new ClassCliente();
                        ClassClienteBindingSource.DataSource = c.RelatorioClienteSEXO(s);
                        this.reportViewer1.RefreshReport();
                    }
                    //else MessageBox.Show("Verificar Campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                if (cbTipo.SelectedIndex == 7)
                {
                    if (RdAtiv.Checked == true || RdInat.Checked == true)
                    {
                        int s = 1;
                        if (RdAtiv.Checked == true) s = 1;
                        if (RdInat.Checked == true) s = 0;

                        ClassCliente c = new ClassCliente();
                        ClassClienteBindingSource.DataSource = c.RelatorioClienteSTATUS(s);
                        this.reportViewer1.RefreshReport();
                    }
                    else MessageBox.Show("Verificar Campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.TrocarTipo();

            if (cbTipo.SelectedIndex == 0)
            {
                lbDia.Visible = true;
                mskDia.Visible = true;
                lbMes.Visible = true;
                cbMes.Visible = true;
            }
            if (cbTipo.SelectedIndex == 1)
            {
                lbMes.Visible = true;
                cbMes.Visible = true;
            }
            if (cbTipo.SelectedIndex == 2)
            {
                lbDia.Visible = true;
                mskDia.Visible = true;
                lbMes.Visible = true;
                cbMes.Visible = true;
                mskAno.Visible = true;
                lbAno.Visible = true;
            }
            if (cbTipo.SelectedIndex == 3)
            {
                lbIdin.Visible = true;
                lbIdfin.Visible = true;
                TxtIdfin.Visible = true;
                TxtIdin.Visible = true;
            }
            if (cbTipo.SelectedIndex == 4)
            {
                lbIdin.Visible = true;
                TxtIdin.Visible = true;
            }
            if (cbTipo.SelectedIndex == 5)
            {
                LbCidade.Visible = true;
                CbCidade.Visible = true;
            }
            if (cbTipo.SelectedIndex == 6)
            {
                lbSexo.Visible = true;
                RdFem.Visible = true;
                RdMasc.Visible = true;
            }
            if (cbTipo.SelectedIndex == 7)
            {
                lbStatus.Visible = true;
                RdAtiv.Visible = true;
                RdInat.Visible = true;
            }

        }

        private void frmGerarRelatorio_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
            this.TrocarTipo();
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
