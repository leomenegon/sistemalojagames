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
    public partial class frmCadastroPlataforma : Form
    {
        public frmCadastroPlataforma()
        {
            InitializeComponent();
        }

        private void btCadPlat_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                ClassConexao cCon = new ClassConexao();
                ClassPlataforma cPlat = new ClassPlataforma();

                cPlat.NomePlat = txtNome.Text;

                int aux = cPlat.CadPlat();

                if (aux != 0) MessageBox.Show("A Plataforma '" + cPlat.NomePlat + "' foi Cadastrada com Sucesso!","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                else MessageBox.Show("Erro ao Realizar Cadastro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Verificar campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
