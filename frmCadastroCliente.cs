using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SistemaLojaGames
{

    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtCpf.Text != "   .   .   -" && txtDataNasc.Text != "  /  /" && CbEst.SelectedIndex!=-1 && CB_OREMISSOR.SelectedIndex != -1)
            {
                ClassConexao cCon = new ClassConexao();
                ClassCliente cClie = new ClassCliente();



                if (radMasc.Checked == true) cClie.SexoCliente = 0;
                if (radFem.Checked == true) cClie.SexoCliente = 1;
                if (radFem.Checked == false && radMasc.Checked == false) MessageBox.Show("Selecione um Sexo!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {

                    cClie.NomeCliente = txtNome.Text;
                    cClie.NomeSocCliente = txtNomeSoc.Text;
                    cClie.TelCliente1 = txtTel1.Text;
                    cClie.TelCliente2 = txtTel2.Text;
                    cClie.CpfCliente = txtCpf.Text;
                    cClie.RgClie = txtRg.Text;
                    cClie.OrgEmiClie = CB_OREMISSOR.SelectedItem.ToString();
                    cClie.EndCepCliente = txtCep.Text;
                    cClie.EndCityCliente = txtCidade.Text;
                    cClie.EndRuaCliente = txtEnd.Text;
                    cClie.EndEstadoCliente = Convert.ToString(CbEst.SelectedItem);
                    cClie.DataNascClie = Convert.ToDateTime(txtDataNasc.Text);

                    int aux = cClie.CadastrarCliente();

                    if (aux != 0) MessageBox.Show("O Cliente '" + cClie.NomeCliente + "' foi Cadastrado com Sucesso!","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    else MessageBox.Show("Erro ao Realizar Cadastro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (txtNome.Text == "") txtNome.BackColor = Color.DarkRed;
                txtCpf.BackColor = Color.DarkRed;
                txtDataNasc.BackColor = Color.DarkRed;
                txtRg.BackColor = Color.DarkRed;
                txtCep.BackColor = Color.DarkRed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void frmCadastroCliente_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void dataCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btClearCat_Click(object sender, EventArgs e)
        {
            txtCep.Clear();
            txtCidade.Clear();
            txtCpf.Clear();
            txtDataNasc.Clear();
            txtEnd.Clear();
            txtNome.Clear();
            txtNomeSoc.Clear();
            txtTel1.Clear();
            txtTel2.Clear();
            txtRg.Clear();
            CbEst.SelectedIndex = -1;
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtAtt_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtCpf.Text != "   .   .   -" && txtDataNasc.Text != "  /  /" && CbEst.SelectedIndex != -1 && CB_OREMISSOR.SelectedIndex != -1)
            {
                ClassConexao cCon = new ClassConexao();
                ClassCliente cClie = new ClassCliente();



                if (radMasc.Checked == true) cClie.SexoCliente = 0;
                if (radFem.Checked == true) cClie.SexoCliente = 1;
                if (radFem.Checked == false && radMasc.Checked == false) MessageBox.Show("Selecione um Sexo!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {

                    cClie.NomeCliente = txtNome.Text;
                    cClie.NomeSocCliente = txtNomeSoc.Text;
                    cClie.TelCliente1 = txtTel1.Text;
                    cClie.TelCliente2 = txtTel2.Text;
                    cClie.CpfCliente = txtCpf.Text;
                    cClie.RgClie = txtRg.Text;
                    cClie.OrgEmiClie = CB_OREMISSOR.SelectedItem.ToString();
                    cClie.EndCepCliente = txtCep.Text;
                    cClie.EndCityCliente = txtCidade.Text;
                    cClie.EndRuaCliente = txtEnd.Text;
                    cClie.EndEstadoCliente = Convert.ToString(CbEst.SelectedItem);
                    cClie.DataNascClie = Convert.ToDateTime(txtDataNasc.Text);
                    cClie.CodCliente = Convert.ToInt32(txtCod.Text);
                    if (chkAtivo.Checked == true) cClie.StatusClieI = 1; else cClie.StatusClieI = 0;


                    int aux = cClie.AttClie();

                    if (aux != 0) MessageBox.Show("O Cliente '" + cClie.NomeCliente + "' foi Atualizado com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else MessageBox.Show("Erro ao Realizar Atualização!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verificar campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //if (txtNome.Text == "") txtNome.BackColor = Color.DarkRed;
                //txtCpf.BackColor = Color.DarkRed;
                //txtDataNasc.BackColor = Color.DarkRed;
                //txtRg.BackColor = Color.DarkRed;
                //txtCep.BackColor = Color.DarkRed;
            }
        }
    }

}

