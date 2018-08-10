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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja Sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) this.Close();
        }

        private void btCadastro_ButtonClick(object sender, EventArgs e)
        {
           
        }

        private void barraStatus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    data.Text = DateTime.Now.ToShortDateString() + "  |  " + DateTime.Now.ToShortTimeString();
        //}

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastroCliente>().Count() > 0)
            {
                MessageBox.Show("Este formulário já está aberto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmCadastroCliente objCad = new frmCadastroCliente();
                //objCad.MdiParent = this;
                objCad.Show();
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastroCategoria>().Count() > 0)
            {
                MessageBox.Show("Este formulário já está aberto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmCadastroCategoria objFrmCat = new frmCadastroCategoria();
                //objFrmCat.MdiParent = this;
                objFrmCat.Show();
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastroProduto>().Count() > 0)
            {
                MessageBox.Show("Este formulário já está aberto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmCadastroProduto objCad = new frmCadastroProduto();
                //objCad.MdiParent = this;
                objCad.Show();
            }
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastroFuncionario>().Count() > 0)
            {
                MessageBox.Show("Este formulário já está aberto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmCadastroFuncionario objCad = new frmCadastroFuncionario();
                //objCad.MdiParent = this;
                objCad.Show();
            }
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduto objConProd = new frmConsultaProduto();
            //objConProd.MdiParent = this;
            objConProd.Show();
        }

        private void plataformaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPlataforma objCadPlat = new frmCadastroPlataforma();
            //objCadPlat.MdiParent = this;
            objCadPlat.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente objConClie = new frmConsultaCliente();
            //objConClie.MdiParent = this;
            objConClie.Show();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptClie1 rs = new frmRptClie1();
            //rs.MdiParent = this;            
            rs.Show();
        }

        private void menuFeraramentas_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btRelatorio_ButtonClick(object sender, EventArgs e)
        {

        }

        private void btVendas_ButtonClick(object sender, EventArgs e)
        {
            frmVendaInfo34 v = new frmVendaInfo34();
            v.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptVenda v = new frmRptVenda();
            v.Show();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmGerarRelatorio f = new frmGerarRelatorio();
            f.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void cadastrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendaInfo34 v = new frmVendaInfo34();
            v.Show();
        }
    }
}
