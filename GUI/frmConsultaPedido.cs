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
    public partial class frmConsultaPedido : Form
    {

        public frmConsultaPedido()
        {
            InitializeComponent();
        }

        public int codigo = 0;
        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPedido bll = new BLLPedido(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void frmConsultaPedido_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].Width = 150;
            dgvDados.Columns[2].Width = 50;
            dgvDados.Columns[3].Width = 50;
            dgvDados.Columns[4].Width = 90;
            dgvDados.Columns[5].Width = 50;
            dgvDados.Columns[6].Width = 70;
            dgvDados.Columns[7].Width = 70;
        }
    }
}
