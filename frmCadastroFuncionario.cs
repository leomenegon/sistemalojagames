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
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtCpf.Text != "" && txtTel1.Text !="" && txtRua.Text !="" && txtCep.Text != "" && txtDataNasc.Text != "" && cbEst.SelectedIndex!=-1)
            {
                ClassConexao cCon = new ClassConexao();
                ClassFuncionario cFunc = new ClassFuncionario();

                int Sexo;

                if (radMasc.Checked == true) Sexo = 0;
                else Sexo = 1;

                cFunc.NomeFunc = txtNome.Text;
                cFunc.NomeSocFunc = txtNomeSoc.Text;
                cFunc.TelFunc1 = txtTel1.Text;
                cFunc.TelFunc2 = txtTel2.Text;
                cFunc.CpfFunc = txtCpf.Text;
                cFunc.EndCepFunc = txtCep.Text;
                cFunc.EndCityFunc = txtCity.Text;
                cFunc.EndRuaFunc = txtRua.Text;
                cFunc.EndEstadoFunc = Convert.ToString(cbEst.SelectedItem);
                cFunc.SexoFunc = Sexo;
                cFunc.UserFunc = txtUser.Text;
                cFunc.PassFunc = txtPass.Text;
                cFunc.StatusFunc = 1;
                cFunc.DataNascFunc = txtDataNasc.Text;

                int aux = cFunc.CadastrarFuncionario();

                if (aux != 0) MessageBox.Show("O Funcionário '" + cFunc.NomeFunc + "' foi Cadastrado com Sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);

                else MessageBox.Show("Erro ao Realizar Cadastro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Verificar Campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txtNome.Text == "") txtNome.BackColor = Color.DarkRed;
                /*   if (txtCpf.TextLength != 14)*/
                txtCpf.BackColor = Color.DarkRed;
                txtDataNasc.BackColor = Color.DarkRed;
                txtRg.BackColor = Color.DarkRed;
                txtCep.BackColor = Color.DarkRed;
            }
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {        

            txtDataCad.Text = DateTime.Now.ToString();

            CB_OREMISSOR.Items.Add("SSP");
            CB_OREMISSOR.Items.Add("ABNC");
            CB_OREMISSOR.Items.Add("CGPI/DUREX/DPF");
            CB_OREMISSOR.Items.Add("CGPI");
            CB_OREMISSOR.Items.Add("CGPMAF");
            CB_OREMISSOR.Items.Add("CNIG");
            CB_OREMISSOR.Items.Add("CNT");
            CB_OREMISSOR.Items.Add("COREN");
            CB_OREMISSOR.Items.Add("CRA");
            CB_OREMISSOR.Items.Add("CRAS");
            CB_OREMISSOR.Items.Add("CRC");
            CB_OREMISSOR.Items.Add("CRE");
            CB_OREMISSOR.Items.Add("CREA");
            CB_OREMISSOR.Items.Add("CRECI");
            CB_OREMISSOR.Items.Add("CREFIT");
            CB_OREMISSOR.Items.Add("CRF");
            CB_OREMISSOR.Items.Add("CRM");
            CB_OREMISSOR.Items.Add("CRN");
            CB_OREMISSOR.Items.Add("CRO");
            CB_OREMISSOR.Items.Add("CRP");
            CB_OREMISSOR.Items.Add("CRPRE");
            CB_OREMISSOR.Items.Add("CRQ");
            CB_OREMISSOR.Items.Add("CRRC");
            CB_OREMISSOR.Items.Add("CRMV");
            CB_OREMISSOR.Items.Add("CSC");
            CB_OREMISSOR.Items.Add("CTPS");
            CB_OREMISSOR.Items.Add("DIC");
            CB_OREMISSOR.Items.Add("DIREX");
            CB_OREMISSOR.Items.Add("DPMAF");
            CB_OREMISSOR.Items.Add("DPT");
            CB_OREMISSOR.Items.Add("DST");
            CB_OREMISSOR.Items.Add("FGTS");
            CB_OREMISSOR.Items.Add("FIPE");
            CB_OREMISSOR.Items.Add("FLS");
            CB_OREMISSOR.Items.Add("GOVGO");
            CB_OREMISSOR.Items.Add("I CLA");
            CB_OREMISSOR.Items.Add("IFP");
            CB_OREMISSOR.Items.Add("IGP");
            CB_OREMISSOR.Items.Add("IICCECF/RO");
            CB_OREMISSOR.Items.Add("IIMG");
            CB_OREMISSOR.Items.Add("IML");
            CB_OREMISSOR.Items.Add("IPC");
            CB_OREMISSOR.Items.Add("IPF");
            CB_OREMISSOR.Items.Add("MAE");
            CB_OREMISSOR.Items.Add("MEX");
            CB_OREMISSOR.Items.Add("MMA");
            CB_OREMISSOR.Items.Add("OAB");
            CB_OREMISSOR.Items.Add("OMB");
            CB_OREMISSOR.Items.Add("PCMG");
            CB_OREMISSOR.Items.Add("PMMG");
            CB_OREMISSOR.Items.Add("POF ou DPF");
            CB_OREMISSOR.Items.Add("POM");
            CB_OREMISSOR.Items.Add("SDS");
            CB_OREMISSOR.Items.Add("SNJ");
            CB_OREMISSOR.Items.Add("SECC");
            CB_OREMISSOR.Items.Add("SEJUSP");
            CB_OREMISSOR.Items.Add("SES ou EST");
            CB_OREMISSOR.Items.Add("SESP");
            CB_OREMISSOR.Items.Add("SJS");
            CB_OREMISSOR.Items.Add("SJTC");
            CB_OREMISSOR.Items.Add("SJTS");
            CB_OREMISSOR.Items.Add("SPTC");
            CB_OREMISSOR.Items.Add("ABNC");
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtTel3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void frmCadastroFuncionario_MouseDown(object sender, MouseEventArgs e)
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

        private void btClearCat_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario f = new frmCadastroFuncionario();
            f.Show();
            this.Close();
        }
    }
}
