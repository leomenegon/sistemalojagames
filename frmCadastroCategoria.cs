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
    public partial class frmCadastroCategoria : Form
    {
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

        private void frmCadastroCategoria_Load(object sender, EventArgs e)
        {
            dataCad.Text = DateTime.Now.ToString();
        }

        private void btCadCat_Click(object sender, EventArgs e)
        {
            if (txtNomeCat.Text != "")
            {
                ClassConexao cCon = new ClassConexao();
                ClassCategoria cCat = new ClassCategoria();

                cCat.NomeCategoria = txtNomeCat.Text;
                cCat.DescricaoCategoria = txtDescCat.Text;

                int aux = cCat.CadastrarCategoria();

                if (aux != 0) MessageBox.Show("A Categoria '" + cCat.NomeCategoria + "' foi Cadastrada com Sucesso!","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                else MessageBox.Show("Erro ao Realizar Cadastro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Verificar Campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btExitCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClearCat_Click(object sender, EventArgs e)
        {
            txtNomeCat.Clear();
            txtCod.Clear();
            txtDescCat.Clear();
        }

        private void btAttCat_Click(object sender, EventArgs e)
        {

        }

        private void boxStatusCat_CheckedChanged(object sender, EventArgs e)
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
        private void dataCad_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

