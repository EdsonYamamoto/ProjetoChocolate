using BBL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmRelatorioGanho : Form
    {
        public frmRelatorioGanho()
        {
            InitializeComponent();
        }

        public int codigo = 0;
        
        private void frmRelatorioGanho_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLRelatorioPedido bll = new BLLRelatorioPedido(cx);
            dgvDados.DataSource = bll.LocalizarGanhos();
            dgvDados1.DataSource = bll.LocalizarPedidoCliente();
            dgvDados2.DataSource = bll.LocalizarPedidoData();

            dgvDados1.Columns[0].HeaderText = "ID";
            dgvDados1.Columns[0].Width = 40;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDados1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvDados2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
