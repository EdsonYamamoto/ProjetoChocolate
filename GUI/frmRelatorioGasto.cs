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
    public partial class frmRelatorioGasto : Form
    {
        public frmRelatorioGasto()
        {
            InitializeComponent();
        }

        private void frmRelatorioGasto_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLRelatorioGasto bll = new BLLRelatorioGasto(cx);
            dgvDados1.DataSource = bll.LocalizarGastos();
            dgvDados.DataSource = bll.LocalizarGastosProduto();
            dgvDados2.DataSource = bll.LocalizarGastoData();
            dgvDados1.Columns[0].HeaderText = "ID";
            dgvDados1.Columns[0].Width = 40;
            dgvDados1.Columns[1].HeaderText = "Fabricante";
            dgvDados1.Columns[1].Width = 100;
            dgvDados1.Columns[3].HeaderText = "QTD";
            dgvDados1.Columns[3].Width = 40;
            dgvDados1.Columns[4].HeaderText = "Unidade";
            dgvDados1.Columns[4].Width = 50;
            dgvDados1.Columns[5].HeaderText = "Medida";
            dgvDados1.Columns[5].Width = 50;
        }
    }
}
