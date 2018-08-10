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
    public partial class frmRptClie1 : Form
    {
        public frmRptClie1()
        {
            InitializeComponent();
        }

        private void frmRptClie1_Load(object sender, EventArgs e)
        {
            ClassCliente cc = new ClassCliente();
            ClassClienteBindingSource.DataSource = cc.rptSimples();
            this.rptSimples.RefreshReport();
        }

        private void ClassClienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
