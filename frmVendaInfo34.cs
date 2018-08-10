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
    public partial class frmVendaInfo34 : Form
    {
        public frmVendaInfo34()
        {
            InitializeComponent();
        }

        private List<ClassCarrinho> lstCarrinho = new List<ClassCarrinho>();

        private decimal VendaT = 0;
        private int CodLastProd = 0;
        private int QtdeN = 0;

        private void frmVendaInfo34_Load(object sender, EventArgs e)
        {
            ClassFuncionario c = new ClassFuncionario();
            cbFuncionario.DataSource = c.SearchFuncV();
            cbFuncionario.DisplayMember = "Nome";
            cbFuncionario.ValueMember = "CodFuncionario";
            cbFuncionario.SelectedIndex = -1;
        }
        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            ClassCliente c = new ClassCliente();
            string s = txtPesqCliente.Text;
            dgvCliente.DataSource = c.SearchClieNomeV(s);
        }
        private void btBuscaProduto_Click(object sender, EventArgs e)
        {
            ClassProduto c = new ClassProduto();
            string s = txtPesqProduto.Text;
            dgvProduto.DataSource = c.SearchProdNomeV(s);
        }
        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassProduto cp = new ClassProduto();

            bool a = cp.VProdFill((int)dgvProduto.SelectedRows[0].Cells[0].Value);
            if (a)
            {
                int Estq, Qtde;
                bool tem = lstCarrinho.Any(c => c.Produto == (int)dgvProduto.SelectedRows[0].Cells[0].Value);

                if (tem)
                {
                    int linha = -1;

                    foreach (DataGridViewRow row in dgvItens.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(dgvProduto.SelectedRows[0].Cells[0].Value.ToString()))
                        {
                            linha = row.Index;
                            break;
                        }
                    }
                    Estq = cp.QtdeProd - Convert.ToInt32(dgvItens.Rows[linha].Cells[2].Value);
                    if (Estq == 0) Qtde = 0;
                    else Qtde = 1;
                }

                else
                {
                    Estq = cp.QtdeProd;
                    Qtde = 1;
                }


                txtProduto.Text = cp.NomeProd;
                txtEstoque.Text = Estq.ToString();
                txtValor.Text = cp.PrecoProd.ToString("n2");
                txtQtde.Text = Qtde.ToString();
                txtQtde.Select();
                txtQtde_TextChanged(this, new EventArgs());

                CodLastProd = cp.CodProd;
                QtdeN = 0;
            }            
        }
        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            if (txtQtde.Text != "" && txtValor.Text != "")
            {
                double res = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);

                if (Convert.ToDouble(txtQtde.Text) > Convert.ToDouble(txtEstoque.Text))
                {
                    MessageBox.Show("A Quantidade excede o Estoque!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtde.Text = "0";
                    res = 0;
                }
                txtTotal.Text = res.ToString("n2");
            }
        }
        private void txtValorDesconto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorDesconto.Text))
            {
                double t = Convert.ToDouble(txtValorTotal.Text);
                txtTotalVenda.Text = t.ToString("n2");
                txtTotalDesconto.Text = "0,00";
            }
            else
            {
                double p, t, v;
                p = 1 - (Convert.ToDouble(txtValorDesconto.Text) / 100);
                v = Convert.ToDouble(txtValorTotal.Text);
                t = v * p;
                txtTotalVenda.Text = t.ToString("n2");
                txtTotalDesconto.Text = (Convert.ToDouble(txtValorDesconto.Text) / 100 * v).ToString("n2");
            }        
        }
        private void AttGrid()
        {
            ClassProduto cp = new ClassProduto();
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("Código"));
            dt.Columns.Add(new DataColumn("Produto"));
            dt.Columns.Add(new DataColumn("Qtde."));
            dt.Columns.Add(new DataColumn("Preço"));

            foreach (ClassCarrinho item in lstCarrinho)
            {
                if (item.Produto==CodLastProd && QtdeN != 0) item.Qtde = QtdeN;
                dt.Rows.Add(item.Produto, cp.VProdNome(item.Produto), item.Qtde, item.Valor);
                dt.AcceptChanges();
            }
            dgvItens.DataSource = dt;
        }
        private void AttQtde(int qtde, int cod)
        {
            ClassProduto cp = new ClassProduto();            
            cp.VProdFill(cod);
            int e = cp.QtdeProd;
            cp.VProdUpdate(e-qtde, cod);
        }
        private void btFechaVenda_Click(object sender, EventArgs e)
        {
            if (cbFuncionario.SelectedIndex != -1 && dgvCliente.DataSource != null && dgvItens.DataSource != null && cbFormaPagamento.SelectedIndex != -1)
            {
                ClassVenda cv = new ClassVenda();
                cv.Cliente = (int)dgvCliente.SelectedRows[0].Cells[0].Value;
                cv.Vendedor = Convert.ToInt32(cbFuncionario.SelectedValue);
                cv.Valor = Convert.ToDecimal(txtTotalVenda.Text);
                cv.Obs = txtObservacao.Text;
                cv.FormaPgto = cbFormaPagamento.SelectedItem.ToString();
                cv.PDesconto = Convert.ToInt32(txtValorDesconto.Text);
                cv.VDesconto = Convert.ToDecimal(txtTotalDesconto.Text);

                bool aux = cv.FVenda();

                if (aux)
                {
                    aux = false;

                    foreach (ClassCarrinho i in lstCarrinho)
                    {
                        i.Venda = cv.Venda;
                        aux = i.CCarrinho(cv.CodVendaCr);

                        AttQtde(i.Qtde, i.Produto);
                    }
                    if (aux==false)
                    {                        
                        MessageBox.Show("Sucesso");
                        this.FrmClean();                        
                    }
                }
                else MessageBox.Show("Erro query");
            }
            else MessageBox.Show("erro campos");
        }
        private void FrmClean()
        {
            txtProduto.Clear();
            txtQtde.Clear();
            txtEstoque.Clear();
            txtValor.Clear();
            txtTotal.Clear();
            txtTotalDesconto.Clear();
            txtValorDesconto.Clear();
            txtPesqCliente.Clear();
            txtPesqProduto.Clear();
            txtObservacao.Clear();
            txtValorTotal.Clear();
            txtTotalVenda.Text = "";

            cbFormaPagamento.SelectedIndex = -1;
            cbFuncionario.SelectedIndex = -1;

            dgvCliente.DataSource = null;
            dgvItens.DataSource = null;
            dgvProduto.DataSource = null;            
        }
        private void btAddProduto_Click(object sender, EventArgs e)
        {
            bool tem = lstCarrinho.Any(c => c.Produto == CodLastProd);

            if (string.IsNullOrEmpty(txtTotal.Text) || string.IsNullOrEmpty(txtQtde.Text) || Convert.ToInt32(txtQtde.Text) == 0)
            {
                MessageBox.Show("Não há um Produto para ser Inserido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tem)
                {
                    int linha = -1;

                    foreach (DataGridViewRow row in dgvItens.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(CodLastProd.ToString()))
                        {
                            linha = row.Index;
                            break;
                        }
                    }
                    QtdeN = Convert.ToInt32(dgvItens.Rows[linha].Cells[2].Value) + Convert.ToInt32(txtQtde.Text);


                    dgvItens.Rows[linha].Cells[2].Value = QtdeN;
                    AttGrid();

                    txtValorDesconto.Text = "0";
                    txtValorDesconto_TextChanged(this, new EventArgs());
                    txtProduto.Clear();
                    txtQtde.Text = "0";
                    txtEstoque.Clear();
                    txtValor.Clear();
                    txtTotal.Clear();
                }
                else
                {

                    ClassCarrinho cr = new ClassCarrinho();
                    decimal vTotal = 0;

                    int qtdeE = Convert.ToInt32(txtEstoque.Text);
                    int qtdeV = Convert.ToInt32(txtQtde.Text);

                    if (!string.IsNullOrEmpty(txtTotal.Text))
                    {
                        vTotal = Convert.ToDecimal(txtTotal.Text);
                        VendaT = vTotal + VendaT;
                        txtValorTotal.Text = VendaT.ToString("n2");
                        txtEstoque.Text = (qtdeE - qtdeV).ToString();

                        cr.Valor = Convert.ToDecimal(txtTotal.Text);
                        cr.Produto = (int)(dgvProduto.SelectedRows[0].Cells[0].Value);
                        cr.Qtde = Convert.ToInt32(txtQtde.Text);

                        lstCarrinho.Add(cr);

                        AttGrid();

                        txtValorDesconto.Text = "0";
                        txtValorDesconto_TextChanged(this, new EventArgs());
                        txtProduto.Clear();
                        txtQtde.Text = "0";
                        txtEstoque.Clear();
                        txtValor.Clear();
                        txtTotal.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Selecione um Produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }
        private void btRemoveProduto_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count > 0)
            {
                decimal v = Convert.ToDecimal(dgvItens.SelectedRows[0].Cells[3].Value);
                VendaT = VendaT - v;
                txtTotalVenda.Text = VendaT.ToString("n2");
                txtValorTotal.Text = VendaT.ToString("n2");

                lstCarrinho.RemoveAt(dgvItens.CurrentRow.Index);
                AttGrid();
                txtValorDesconto_TextChanged(this, new EventArgs());
            }
            else MessageBox.Show("Não há Item para ser Removido!");
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvProduto_CellContentClick(object sender, KeyPressEventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
