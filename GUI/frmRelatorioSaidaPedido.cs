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
    public partial class frmRelatorioSaidaPedido : Form
    {
        public frmRelatorioSaidaPedido()
        {
            InitializeComponent();
        }

        private void frmRelatorioSaidaPedido_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLRelatorioVendas bll = new BLLRelatorioVendas(cx);
            dgvDados.DataSource = bll.LocalizarVenda();
            dgvDados1.DataSource = bll.LocalizarVendaManufaturado();
            dgvDados2.DataSource = bll.LocalizarVendaFabricar();

            dgvDados1.Columns[0].HeaderText = "ID";
            dgvDados1.Columns[0].Width = 40;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
